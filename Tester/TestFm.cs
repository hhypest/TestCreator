using ProtoBuf;
using TestCls;

namespace Tester
{
    internal partial class TestFm : Form
    {
        private int Count { get; set; }

        private TestFrame Test { get; set; }

        private Queue<(string ask, (string name, bool state)[] variant)> Failask { get; }

        private List<(string ask, (string name, bool state)[] variant)> List { get; }

        internal TestFm(string path)
        {
            InitializeComponent();

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read);
            Test = Serializer.Deserialize<TestFrame>(stream);
            Count = Test.Count;
            NameTool.Text = $"<{Test.NameTest}>";
            CountTool.Text = $"Осталось вопросов {Count} из {Test.Count}";

            List = new List<(string ask, (string name, bool state)[] variant)>();
            Failask = new Queue<(string ask, (string name, bool state)[] variant)>();

            foreach (KeyValuePair<string, (string name, bool state)[]> key in Test.GetTesterList())
                List.Add((key.Key, key.Value));

            ShowAsk();
        }

        internal int GetCount()
            => Test.Count;

        internal ParallelQuery<(string, (string, bool)[])> GetResult()
            => Failask.AsParallel();

        private static int GetIndex(int min, int max)
            => new Random().Next(min, max);

        private (string ask, (string name, bool state)[] variant) NextAsk()
        {
            if (Count == 0)
                return List[0];

            int index = GetIndex(0, Count);
            Count--;
            (string ask, (string name, bool state)[] variant) = List[index];
            List.RemoveAt(index);
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
                                              where item.Checked && (bool)item.Tag && item.Checked == (bool)item.Tag
                                              select item;
            return check.Any();
        }

        private void NextButt_Click(object sender, EventArgs e)
        {
            if (!GetCheck())
                Failask.Enqueue(((string ask, (string name, bool state)[] variant))AskLabel.Tag);

            AskLabel.Text = string.Empty;
            AskLabel.Tag = null;
            QuestList.Items.Clear();

            if (List.Count < 1)
            {
                Close();
                return;
            }

            CountTool.Text = $"Осталось вопросов {Count} из {Test.Count}";
            ShowAsk();
        }
    }
}