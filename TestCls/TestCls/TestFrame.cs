using ProtoBuf;

namespace TestCls
{
    [ProtoContract(SkipConstructor = true)]
    public partial class TestFrame : object
    {
        #region[Свойства]

        [ProtoMember(1, Name = "Имя")]
        public string NameTest { get; set; }

        [ProtoMember(2, Name = "Путь")]
        public string PathTest { get; set; }

        [ProtoMember(3, Name = "Количество")]
        public int Count { get; set; }

        [ProtoMember(4, Name = "Мультиответ")]
        public bool Multione { get; set; }

        [ProtoMember(5, Name = "Словарь")]
        private IDictionary<Guid, Ask> List { get; }

        #endregion

        #region[Коструктор]

        public TestFrame(string name, bool multione)
        {
            NameTest = name;
            Multione = multione;
            PathTest = string.Empty;
            Count = 0;
            List = new Dictionary<Guid, Ask>();
        }

        #endregion

        #region[Методы]

        public void NewAsk(string asks, (string name, bool state)[] variants)
        {
            Ask ask = new(asks, variants);
            if (!List.ContainsKey(ask.Guid))
                List.Add(ask.Guid, ask);
            else
            {
                List.Remove(ask.Guid);
                List.Add(ask.Guid, ask);
            }

            Count++;
        }

        public void NewAsk((string asks, (string name, bool state)[] variants) newitem)
        {
            Ask ask = new(newitem.asks, newitem.variants);
            if (!List.ContainsKey(ask.Guid))
                List.Add(ask.Guid, ask);
            else
            {
                List.Remove(ask.Guid);
                List.Add(ask.Guid, ask);
            }

            Count++;
        }

        public ParallelQuery<KeyValuePair<Guid, string>> GetTreeAsk()
            => from KeyValuePair<Guid, Ask> key in List.AsParallel()
               select new KeyValuePair<Guid, string>(key.Key, key.Value.Name);

        public ParallelQuery<KeyValuePair<string, (string name, bool state)[]>> GetTesterList()
            => from KeyValuePair<Guid, Ask> key in List.AsParallel()
               select new KeyValuePair<string, (string name, bool state)[]>(key.Value.Name, key.Value.GetVariants());

        public ParallelQuery<(string name, bool state)> GetListAsk(Guid tag)
            => List[tag].GetVariants().AsParallel();

        public (string asks, (string name, bool state)[] variants) GetEditAsk(Guid tag)
            => (List[tag].Name, List[tag].GetVariants());

        public void RemoveAsk(Guid tag)
        {
            List.Remove(tag);
            Count--;
        }

        public void RemoveAsk()
        {
            List.Clear();
            Count = 0;
        }

        #endregion

        #region[Струтура вопрос\варианты ответа]

        [ProtoContract]
        private struct Ask
        {
            [ProtoMember(1, Name = "Ключ")]
            public Guid Guid { get; set; }

            [ProtoMember(2, Name = "Вопрос")]
            public string Name { get; set; }

            [ProtoMember(3, Name = "Количество")]
            public int Count { get; set; }

            [ProtoMember(4, Name = "Варианты")]
            private Variant[] Variants { get; set; }

            public Ask(string name, (string var, bool state)[] variants) : this()
            {
                Name = name;
                Guid = Guid.NewGuid();
                Variants = Array.ConvertAll<(string name, bool state), Variant>(variants,
                                                                                 a => new Variant(a));
                Count = Variants.Length;
            }

            public (string var, bool state)[] GetVariants()
                => Array.ConvertAll(Variants, a => a.GetVariant());

            #region[Структура вариант ответа]

            [ProtoContract]
            private struct Variant
            {
                [ProtoMember(1, Name = "Вариант")]
                public string Name { get; set; }

                [ProtoMember(2, Name = "Булево")]
                public bool State { get; set; }

                public Variant((string name, bool state) tuple) : this()
                {
                    Name = tuple.name;
                    State = tuple.state;
                }

                public (string name, bool state) GetVariant()
                    => (Name, State);
            }

            #endregion
        }

        #endregion
    }
}