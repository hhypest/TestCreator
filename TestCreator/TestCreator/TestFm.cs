using ProtoBuf;
using System.Text;
using System.Xml;
using TestCls;

namespace TestCreator
{
    internal partial class TestFm : Form
    {
        internal TestFrame Test;

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

        internal void SaveTest(string path)
        {
            using FileStream stream = new(path, FileMode.Create, FileAccess.Write);
            Serializer.Serialize(stream, Test);
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
        {
            EditAskMenu_Click(sender, e);
        }

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
            main.MainFm_MdiChildActivate(sender, e);
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
            var with = AnswerList.Items;
            foreach (ListViewItem item in with)
            {
                item.ImageIndex = ((bool)item.Tag) ? 0 : 1;
                item.SubItems.Add(((bool)item.Tag) ? "Да" : "Нет");
            }
        }

        private void SortAZMenu_Click(object sender, EventArgs e)
        {
            IEnumerable<KeyValuePair<Guid, string>> query = from TreeNode node in AskTree.Nodes
                                                            orderby node.Text ascending
                                                            select new KeyValuePair<Guid, string>((Guid)node.Tag, node.Text);

            KeyValuePair<Guid, string>[] sort = query.ToArray();
            AskTree.Nodes.Clear();
            AnswerList.Items.Clear();

            foreach (KeyValuePair<Guid, string> item in sort)
                AskTree.Nodes.Add(item.Value).Tag = item.Key;
        }

        private void SortZAMenu_Click(object sender, EventArgs e)
        {
            IEnumerable<KeyValuePair<Guid, string>> query = from TreeNode node in AskTree.Nodes
                                                            orderby node.Text descending
                                                            select new KeyValuePair<Guid, string>((Guid)node.Tag, node.Text);

            KeyValuePair<Guid, string>[] sort = query.ToArray();
            AskTree.Nodes.Clear();
            AnswerList.Items.Clear();

            foreach (KeyValuePair<Guid, string> item in sort)
                AskTree.Nodes.Add(item.Value).Tag = item.Key;
        }

        private void UpdateTree()
        {
            ParallelQuery<KeyValuePair<Guid, string>> result = Test.GetTreeAsk();
            AskTree.Nodes.Clear();
            AnswerList.Items.Clear();
            CountTool.Text = $"Количество вопросов - <{Test.Count}>";

            foreach (KeyValuePair<Guid, string> item in result)
                AskTree.Nodes.Add(item.Value).Tag = item.Key;
        }

        private void XmlMenu_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFile = new()
            {
                Title = $"Куда экспортировать тест - <{Test.NameTest}>",
                FileName = Test.NameTest,
                Filter = "Xml файл|*.xml",
                RestoreDirectory = true,
                OverwritePrompt = true
            };
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;

            XmlWriterSettings settings = new()
            {
                Indent = true,
                ConformanceLevel = ConformanceLevel.Document,
                CheckCharacters = true,
                Encoding = Encoding.UTF8,
                NewLineOnAttributes = true
            };

            using FileStream stream = new(saveFile.FileName, FileMode.Create, FileAccess.Write);
            using XmlWriter writer = XmlWriter.Create(stream, settings);
            Test.WriteXml(writer);
        }

        private void JsonMenu_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFile = new()
            {
                Title = $"Куда экспортировать тест - <{Test.NameTest}>",
                FileName = Test.NameTest,
                Filter = "Json файл|*.json",
                RestoreDirectory = true,
                OverwritePrompt = true
            };
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;

            byte[] json = Encoding.UTF8.GetBytes(Test.GetJson());
            using FileStream stream = new(saveFile.FileName, FileMode.Create, FileAccess.Write);
            stream.Position = 0;
            stream.Write(json, 0, json.Length);
        }
    }
}