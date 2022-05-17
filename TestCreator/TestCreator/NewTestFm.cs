namespace TestCreator
{
    public partial class NewTestFm : Form
    {
        public NewTestFm()
        {
            InitializeComponent();
            State = true;
            NameTest = NameBox.Text;
        }

        public NewTestFm(string nametest, bool state)
        {
            InitializeComponent();
            NameTest = nametest;
            NameBox.Text = nametest;
            State = state;

            switch (State)
            {
                case true:
                    MultiRadio.Checked = true;
                    break;

                case false:
                    OneRadio.Checked = true;
                    break;
            }
        }

        public string NameTest { get; set; }
        public bool State { get; set; }

        private void MultiRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!MultiRadio.Checked)
                return;

            State = true;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameTest = NameBox.Text;
        }

        private void OKButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTest) || string.IsNullOrWhiteSpace(NameTest))
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OneRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!OneRadio.Checked)
                return;

            State = false;
        }
    }
}