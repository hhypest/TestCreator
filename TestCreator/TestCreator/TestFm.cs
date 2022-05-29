using ProtoBuf;
using TestCls;

namespace TestCreator
{
    internal partial class TestFm : Form
    {
        internal TestFrame Test { get; set; }

        internal TestFm(string name, bool state)
        {
            InitializeComponent();
            Test = new TestFrame(name, state);
            Text = $"<{name}>";
        }

        internal TestFm(string path)
        {
            InitializeComponent();

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read);
            Test = Serializer.Deserialize<TestFrame>(stream);

            Text = $"<{Test.NameTest}>";
            UpdateTree();
        }

        internal TestFm()
        {
            InitializeComponent();
            Test = new();
        }

        internal void SaveTest(string path)
        {
            using FileStream stream = new(path, FileMode.Create, FileAccess.Write);
            Serializer.Serialize(stream, Test);
        }

        internal void UpdateTree()
        {
            ParallelQuery<KeyValuePair<Guid, string>> result = Test.GetTreeAsk();
            AskTree.Nodes.Clear();
            AnswerList.Items.Clear();
            CountTool.Text = $"Количество вопросов - <{Test.Count}>";

            foreach (KeyValuePair<Guid, string> item in result)
                AskTree.Nodes.Add(item.Value).Tag = item.Key;
        }

        private void AskTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            GuidTool.Text = $"{e.Node.Tag}";
            var with = AnswerList.Items;
            with.Clear();

            ParallelQuery<(string, bool)> result = Test.GetListAsk((Guid)e.Node.Tag);
            foreach ((string name, bool state) in result)
                with.Add(name).Tag = state;

            SetList();
        }

        private void AskTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
            => EditAskMenu_Click(sender, e);

        private void EditAskMenu_Click(object sender, EventArgs e)
        {
            if (AskTree.SelectedNode == null)
                return;

            (string asks, (string name, bool state)[] variants) = Test.GetEditAsk((Guid)AskTree.SelectedNode.Tag);
            using QuestFm dialog = new(asks, variants, Test.Multione);

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Test.RemoveAsk((Guid)AskTree.SelectedNode.Tag);
            Test.NewAsk(dialog.GetValues());
            UpdateTree();
        }

        private void NewAskMenu_Click(object sender, EventArgs e)
        {
            using QuestFm dialog = new(Test.Multione);

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Test.NewAsk(dialog.GetValues());
            UpdateTree();
        }

        private void PropertyMenu_Click(object sender, EventArgs e)
        {
            using NewTestFm dialog = new(Test.NameTest, Test.Multione);

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Test.NameTest = dialog.NameTest;
            Test.Multione = dialog.State;

            MainFm main = (MainFm)MdiParent;
            main.MainFm_MdiChildActivate(this, EventArgs.Empty);
        }

        private void RemoveAllMenu_Click(object sender, EventArgs e)
        {
            if (Test.Count < 1)
                return;

            AnswerList.Items.Clear();
            Test.RemoveAsk();
            AskTree.Nodes.Clear();
            CountTool.Text = $"Количество вопросов - <{Test.Count}>";
        }

        private void RemoveAskMenu_Click(object sender, EventArgs e)
        {
            if (AskTree.SelectedNode == null)
                return;

            AnswerList.Items.Clear();
            Test.RemoveAsk((Guid)AskTree.SelectedNode.Tag);
            UpdateTree();
        }

        private void SetList()
        {
            foreach (ListViewItem item in AnswerList.Items)
            {
                item.ImageIndex = ((bool)item.Tag) ? 0 : 1;
                item.SubItems.Add(((bool)item.Tag) ? "Да" : "Нет");
            }
        }
    }
}