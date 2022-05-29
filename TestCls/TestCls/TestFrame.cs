using Newtonsoft.Json;
using ProtoBuf;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace TestCls
{
    [ProtoContract]
    public class TestFrame : object, IXmlSerializable
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

        #region[Кострукторы]

        public TestFrame(string name, bool multione) : this()
        {
            NameTest = name;
            Multione = multione;
        }

        public TestFrame()
        {
            NameTest = string.Empty;
            PathTest = string.Empty;
            Multione = default;
            Count = 0;
            List = new Dictionary<Guid, Ask>();
        }

        #endregion

        #region[Методы]

        public void NewAsk(string asks, (string name, bool state)[] variants)
        {
            Ask ask = new(asks, variants);
            if (!List.ContainsKey(ask.Guid))
            {
                List.Add(ask.Guid, ask);
            }
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
            {
                List.Add(ask.Guid, ask);
            }
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

        public XmlSchema? GetSchema()
            => null;

        public void ReadXml(XmlReader reader)
        {
            SetXml(XDocument.Load(reader));
        }

        public void WriteXml(XmlWriter writer)
        {
            GetXml().Save(writer);
        }

        public string GetJson()
            => JsonConvert.SerializeXNode(GetXml(), Formatting.Indented);

        public void SetJson(string json)
            => SetXml(JsonConvert.DeserializeXNode(json)!);

        public override string? ToString()
        {
            StringBuilder result = new($"Имя - {NameTest}");
            result.Append('\n');
            result.Append("Сохранен - ").Append(PathTest);
            result.Append('\n');
            result.Append("Несколько вариантов ответа - ").Append(Multione);
            result.Append('\n');
            result.Append("Количество вопросов - ").Append(Count);

            return result.ToString();
        }

        private XDocument GetXml()
        {
            IEnumerable<Ask> items = from item in List.Values
                                     select item;

            XDocument document = new(new XDeclaration("1.0", "utf-8", null));
            XElement root = new("Frame", new XElement("Settings",
                                new XAttribute("Name", NameTest),
                                new XAttribute("Path", PathTest),
                                new XAttribute("MultiOne", Multione),
                                new XAttribute("Count", Count)));
            XElement list = new("Ask");

            foreach (Ask ask in items)
            {
                XElement quest = new("Quest",
                                     new XAttribute("Item", ask.Name),
                                     new XAttribute("ID", ask.Guid));
                foreach ((string name, bool state) in ask.GetVariants())
                {
                    XElement variant = new("Variant", name,
                                           new XAttribute("State", state));
                    quest.Add(variant);
                }

                list.Add(quest);
            }
            root.Add(list);
            document.Add(root);
            return document;
        }

        private void SetXml(XDocument document)
        {
            Queue<(Guid id, string quest, (string name, bool state)[] variants)> asks = new();

            IEnumerable<XElement> quest = document.Descendants("Quest");
            IEnumerable<string> settings = from XAttribute item in document.Descendants("Settings").Attributes()
                                           select item.Value;

            foreach (XElement element in quest)
            {
                string value = element.Attribute("Item")!.Value;
                Guid id = Guid.Parse(element.Attribute("ID")!.Value);
                (string name, bool state)[] variants = new (string, bool)[element.Elements().Count()];
                int count = 0;

                foreach (XElement child in element.Elements())
                {
                    variants[count].name = child.Value;
                    variants[count].state = child.Attribute("State")!.Value.To<bool>();
                    count++;
                }

                asks.Enqueue((id, value, variants));
            }

            UpdateList(asks);

            NameTest = settings.ElementAt(0);
            PathTest = settings.ElementAt(1);
            Multione = settings.ElementAt(2).To<bool>();
            Count = settings.ElementAt(3).To<int>();
        }

        private void UpdateList(Queue<(Guid id, string quest, (string name, bool state)[] variants)> values)
        {
            foreach ((Guid id, string quest, (string name, bool state)[] variants) item in values)
            {
                Ask ask = new(item);
                List.Add(ask.Guid, ask);
            }
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
            private Variant[] Variants { get; }

            public Ask(string name, (string var, bool state)[] variants)
            {
                Name = name;
                Guid = Guid.NewGuid();
                Variants = Array.ConvertAll<(string name, bool state), Variant>(variants,
                                                                                 valueTuple => new Variant(valueTuple));
                Count = Variants.Length;
            }

            public Ask((Guid id, string quest, (string name, bool state)[] variants) ask)
            {
                Guid = ask.id;
                Name = ask.quest;
                Count = ask.variants.Length;
                Variants = Array.ConvertAll(ask.variants,
                                            x => new Variant(x));
            }

            public (string var, bool state)[] GetVariants()
                => Array.ConvertAll(Variants,
                                    valueTuple => valueTuple.GetVariant());

            #region[Структура вариант ответа]

            [ProtoContract]
            private struct Variant
            {
                [ProtoMember(1, Name = "Вариант")]
                public string Name { get; set; }

                [ProtoMember(2, Name = "Булево")]
                public bool State { get; set; }

                public Variant((string name, bool state) tuple)
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