using ProtoBuf;
using TestCls;

namespace Tester
{
    public partial class TestFm : Form
    {
        private int Count { get; set; }
        private TestFrame Test { get; set; }
        private readonly Queue<(string ask, (string name, bool state)[] variant)> failask;
        private readonly List<(string ask, (string name, bool state)[] variant)> list;

        public TestFm(string path)
        {
            InitializeComponent();

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read);
            Test = Serializer.Deserialize<TestFrame>(stream);
            Count = Test.Count;
            NameTool.Text = $"<{Test.NameTest}>";
            CountTool.Text = $"Осталось вопросов {Count} из {Test.Count}";

            list = new List<(string ask, (string name, bool state)[] variant)>();
            failask = new Queue<(string ask, (string name, bool state)[] variant)>();

            foreach (KeyValuePair<string, (string name, bool state)[]> key in Test.GetTesterList())
                list.Add((key.Key, key.Value));

            ShowAsk();
        }

        internal int GetCount()
            => Test.Count;

        internal ParallelQuery<(string, (string, bool)[])> GetResult()
            => failask.AsParallel();

        private static int GetIndex(int min, int max)
            => new Random().Next(min, max);

        private (string ask, (string name, bool state)[] variant) NextAsk()
        {
            if (Count == 0)
            {
                return list[0];
            }

            int index = GetIndex(0, Count);
            Count--;
            (string ask, (string name, bool state)[] variant) = list[index];
            list.RemoveAt(index);
            return (ask, variant);
        }

        private void ShowAsk()
        {
            (string ask, (string name, bool state)[] variant) quest = NextAsk();
            AskLabel.Text = quest.ask;
            AskLabel.Tag = quest;

            var with = QuestList.Items;
            foreach ((string name, bool state) in quest.variant)
                with.Add(name).Tag = state;
        }

        private bool GetCheck()
        {
            IEnumerable<ListViewItem> check = from item in QuestList.Items.Cast<ListViewItem>()
                                              where item.Checked == true & (bool)item.Tag == true & item.Checked == (bool)item.Tag
                                              select item;
            return check.Any();
        }

        private void NextButt_Click(object sender, EventArgs e)
        {
            if (!GetCheck())
                failask.Enqueue(((string ask, (string name, bool state)[] variant))AskLabel.Tag);

            AskLabel.Text = string.Empty;
            AskLabel.Tag = null;
            QuestList.Items.Clear();

            if (list.Count < 1)
            {
                Close();
                return;
            }

            CountTool.Text = $"Осталось вопросов {Count} из {Test.Count}";
            ShowAsk();
        }
    }
}