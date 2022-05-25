using System.Data;

namespace TestCreator
{
    internal partial class InputFm : Form
    {
        internal InputFm()
        {
            InitializeComponent();
        }

        internal IEnumerable<ListViewItem> GetInputs()
            => from string input in VarBox.Lines
               where input != string.Empty
               select new ListViewItem(input);

        private void CancelButt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OKButt_Click(object sender, EventArgs e)
        {
            if (VarBox.Lines.Length == 0)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}