using System.Text;
using System.Xml;

namespace TestCreator
{
    internal partial class MainFm : Form
    {
        private enum FileFormat : byte
        {
            test = 0,
            xml = 1,
            json = 2
        }

        internal MainFm()
            => InitializeComponent();

        internal void MainFm_MdiChildActivate(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
            {
                NameTool.Text = "Открытых тестов нет";
                PathTool.Text = "Открытых тестов нет";

                SaveMenu.Enabled = false;
                ExportMenu.Enabled = false;
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
            ExportMenu.Enabled = true;
        }

        private static string SavePath(FileFormat format)
        {
            using SaveFileDialog saveFile = new()
            {
                RestoreDirectory = true,
                Title = "Куда сохранить тест?",
                Filter = $"{format} файл|*.{format}"
            };

            if (saveFile.ShowDialog() != DialogResult.OK)
                return string.Empty;

            return saveFile.FileName;
        }

        private static string OpenPath(FileFormat format)
        {
            using OpenFileDialog openFile = new()
            {
                RestoreDirectory = true,
                Filter = $"{format} файл|*.{format}",
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Какой тест открыть?"
            };

            if (openFile.ShowDialog() != DialogResult.OK)
                return string.Empty;

            return openFile.FileName;
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
            const FileFormat format = FileFormat.test;
            string path = OpenPath(format);

            if (string.IsNullOrEmpty(path))
                return;

            TestFm child = new(path) { MdiParent = this };
            child.Show();

            NameTool.Text = child.Test.NameTest;
            PathTool.Text = child.Test.PathTest;
        }

        private void SaveAsTestMenu_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            const FileFormat format = FileFormat.test;
            string path = SavePath(format);

            if (string.IsNullOrEmpty(path))
                return;

            child.Test.PathTest = path;
            child.SaveTest(path);
            PathTool.Text = path;
        }

        private void SaveTestMenu_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            child.SaveTest(child.Test.PathTest);
        }

        private void XmlEx_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            const FileFormat format = FileFormat.xml;
            string path = SavePath(format);

            if (string.IsNullOrEmpty(path))
                return;

            XmlWriterSettings settings = new()
            {
                ConformanceLevel = ConformanceLevel.Document,
                Indent = true,
                NewLineOnAttributes = true
            };

            using FileStream stream = new(path, FileMode.Create, FileAccess.Write);
            using XmlWriter writer = XmlWriter.Create(stream, settings);
            child.Test.WriteXml(writer);
        }

        private void JsonEx_Click(object sender, EventArgs e)
        {
            TestFm child = (TestFm)ActiveMdiChild;

            if (child == null)
                return;

            const FileFormat format = FileFormat.json;
            string path = SavePath(format);

            if (string.IsNullOrEmpty(path))
                return;

            byte[] data = Encoding.UTF8.GetBytes(child.Test.GetJson());
            using FileStream stream = new(path, FileMode.Create, FileAccess.Write);
            stream.Position = 0;
            stream.Write(data, 0, data.Length);
        }

        private void XmlImport_Click(object sender, EventArgs e)
        {
            const FileFormat format = FileFormat.xml;
            string path = OpenPath(format);

            if (string.IsNullOrEmpty(path))
                return;

            XmlReaderSettings settings = new()
            {
                ConformanceLevel = ConformanceLevel.Document
            };

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read);
            using XmlReader reader = XmlReader.Create(stream, settings);

            TestFm child = new() { MdiParent = this };
            child.Test.ReadXml(reader);
            child.UpdateTree();
            child.Show();
        }

        private void JsonImport_Click(object sender, EventArgs e)
        {
            const FileFormat format = FileFormat.json;
            string path = OpenPath(format);

            if (string.IsNullOrEmpty(path))
                return;

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read);
            stream.Position = 0;
            byte[] data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);

            TestFm child = new() { MdiParent = this };
            child.Test.SetJson(Encoding.UTF8.GetString(data));
            child.UpdateTree();
            child.Show();
        }
    }
}