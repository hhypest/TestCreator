namespace TestCreator
{
    internal partial class MainFm : Form
    {
        internal MainFm()
        {
            InitializeComponent();
        }

        internal void MainFm_MdiChildActivate(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
            {
                NameTool.Text = "Открытых тестов нет";
                PathTool.Text = "Открытых тестов нет";

                SaveMenu.Enabled = false;
                return;
            }

            if (string.IsNullOrEmpty(child.Test.PathTest))
            {
                PathTool.Text = "Тест не сохранен";
                NameTool.Text = child.Test.NameTest;
                child.Text = child.Test.NameTest;

                SaveTestMenu.Enabled = false;
                SaveMenu.Enabled = true;
                return;
            }

            NameTool.Text = child.Test.NameTest;
            child.Text = child.Test.NameTest;
            PathTool.Text = child.Test.PathTest;

            SaveMenu.Enabled = true;
            SaveTestMenu.Enabled = true;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void NewTestMenu_Click(object sender, EventArgs e)
        {
            using NewTestFm dialog = new();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            TestFm child = new(dialog.NameTest, dialog.State) { MdiParent = this };
            child.Show();
        }

        private void OpenTestMenu_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                RestoreDirectory = true,
                Filter = "Тест|*.test",
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Какой тест открыть?"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            TestFm child = new(openFileDialog.FileName) { MdiParent = this };
            child.Show();

            NameTool.Text = child.Test.NameTest;
            PathTool.Text = child.Test.PathTest;
        }

        private void SaveAsTestMenu_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            using SaveFileDialog saveFileDialog = new()
            {
                RestoreDirectory = true,
                Filter = "Тест|*.test",
                FileName = $"{child.Test.NameTest}",
                Title = $"Куда сохранить тест <{child.Test.NameTest}>"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            child.Test.PathTest = saveFileDialog.FileName;
            child.SaveTest(saveFileDialog.FileName);

            PathTool.Text = saveFileDialog.FileName;
        }

        private void SaveTestMenu_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            child.SaveTest(child.Test.PathTest);
        }
    }
}