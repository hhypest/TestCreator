namespace Tester
{
    public partial class MainFm : Form
    {
        public MainFm()
        {
            InitializeComponent();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void PathButt_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFile = new()
            {
                Title = "Какой тест открыть?",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Тест|*.test"
            };

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            PathTestBox.Text = openFile.FileName;
        }

        private void OKButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text) || string.IsNullOrEmpty(LNameBox.Text) || string.IsNullOrEmpty(PathTestBox.Text))
                return;

            using TestFm dialog = new(PathTestBox.Text);
            dialog.ShowDialog();

            using ResultFm result = new((FNameBox.Text, LNameBox.Text), dialog.GetCount(), dialog.GetResult());
            result.ShowDialog();
        }
    }
}