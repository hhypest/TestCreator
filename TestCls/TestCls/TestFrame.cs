using ProtoBuf;

namespace TestCls
{
    [ProtoContract(SkipConstructor = true)]
    public partial class TestFrame : object
    {
        #region[Поля]

        [ProtoMember(1, Name = "Name")]
        private string _nametest;

        [ProtoMember(2, Name = "Path")]
        private string _pathtest;

        [ProtoMember(3, Name = "Count")]
        private int _count;

        [ProtoMember(4, Name = "MultiOne")]
        private bool _multione;

        [ProtoMember(5, Name = "Ask")]
        private readonly IDictionary<Guid, Ask> _list;

        #endregion

        #region[Свойства]

        public string NameTest { get => _nametest; set => _nametest = value; }
        public string PathTest { get => _pathtest; set => _pathtest = value; }
        public int Count { get => _count; set => _count = value; }
        public bool Multione { get => _multione; set => _multione = value; }

        #endregion

        #region[Коструктор]

        public TestFrame(string name, bool multione)
        {
            _nametest = name;
            _multione = multione;
            _pathtest = string.Empty;
            _count = 0;
            _list = new Dictionary<Guid, Ask>();
        }

        #endregion

        #region[Методы]

        public void NewAsk(string asks, (string name, bool state)[] variants)
        {
            Ask ask = new(asks, variants);
            if (!_list.ContainsKey(ask.Guid))
                _list.Add(ask.Guid, ask);
            else
            {
                _list.Remove(ask.Guid);
                _list.Add(ask.Guid, ask);
            }

            Count++;
        }

        public void NewAsk((string asks, (string name, bool state)[] variants) newitem)
        {
            Ask ask = new(newitem.asks, newitem.variants);
            if (!_list.ContainsKey(ask.Guid))
                _list.Add(ask.Guid, ask);
            else
            {
                _list.Remove(ask.Guid);
                _list.Add(ask.Guid, ask);
            }

            Count++;
        }

        public ParallelQuery<KeyValuePair<Guid, string>> GetTreeAsk()
            => from KeyValuePair<Guid, Ask> key in _list.AsParallel()
               select new KeyValuePair<Guid, string>(key.Key, key.Value.GetName());

        public ParallelQuery<KeyValuePair<string, (string name, bool state)[]>> GetTesterList()
            => from KeyValuePair<Guid, Ask> key in _list.AsParallel()
               select new KeyValuePair<string, (string name, bool state)[]>(key.Value.GetName(), key.Value.GetVariants());

        public ParallelQuery<(string name, bool state)> GetListAsk(Guid tag)
            => _list[tag].GetVariants().AsParallel();

        public (string asks, (string name, bool state)[] variants) GetEditAsk(Guid tag)
            => (_list[tag].GetName(), _list[tag].GetVariants());

        public void RemoveAsk(Guid tag)
        {
            _list.Remove(tag);
            Count--;
        }

        public void RemoveAsk()
        {
            _list.Clear();
            Count = 0;
        }

        #endregion

        #region[Струтура вопрос\варианты ответа]

        [ProtoContract]
        private struct Ask
        {
            [ProtoMember(1, Name = "ID")]
            private Guid _guid;

            [ProtoMember(2, Name = "Ask")]
            private string _name;

            [ProtoMember(3, Name = "Variants")]
            private Variant[] _variants;

            [ProtoMember(4, Name = "CountVariants")]
            private int _count;

            public Guid Guid { get => _guid; set => _guid = value; }
            public string Name { get => _name; set => _name = value; }
            private Variant[] Variants { get => _variants; set => _variants = value; }
            public int Count { get => _count; set => _count = value; }

            public Ask(string name, (string var, bool state)[] variants) : this()
            {
                _name = name;
                _guid = Guid.NewGuid();
                _variants = Array.ConvertAll<(string name, bool state), Variant>(variants,
                                                                                 a => new Variant(a));
                _count = _variants.Length;
            }

            public Guid GetGuid()
                => Guid;

            public string GetName()
                => Name;

            public (string var, bool state)[] GetVariants()
                => Array.ConvertAll(Variants, a => a.GetVariant());

            #region[Структура вариант ответа]

            [ProtoContract]
            private struct Variant
            {
                [ProtoMember(1, Name = "ThisVariant")]
                private string _name;

                [ProtoMember(2, Name = "ThisLogical")]
                private bool _state;

                public string Name { get => _name; set => _name = value; }
                public bool State { get => _state; set => _state = value; }

                public Variant((string name, bool state) tuple) : this()
                {
                    _name = tuple.name;
                    _state = tuple.state;
                }

                public (string name, bool state) GetVariant()
                    => (Name, State);
            }

            #endregion
        }

        #endregion
    }
}