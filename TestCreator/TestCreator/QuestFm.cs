namespace TestCreator
{
    public partial class QuestFm : Form
    {
        public QuestFm(bool multione = true)
        {
            InitializeComponent();
            VariantList.Tag = multione;
            Text = "Новый вопрос";
        }

        public QuestFm(string ask, (string name, bool state)[] variants, bool multione = true)
        {
            InitializeComponent();
            Text = ask;
            AskBox.Text = ask;
            VariantList.Tag = multione;

            var with = VariantList.Items;

            foreach ((string name, bool state) in variants)
                with.Add(name).Checked = state;
        }

        public (string asks, (string name, bool state)[] variants) GetValues()
        {
            IEnumerable<(string, bool)> query = from ListViewItem item in VariantList.Items
                                                where item.Text != string.Empty
                                                select (item.Text, item.Checked);

            return (AskBox.Text, query.ToArray());
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            Visible = false;

            using InputFm dialog = new();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                Visible = true;
                return;
            }

            foreach (string key in dialog.GetInputs())
                VariantList.Items.Add(key);

            Visible = true;
        }

        private void AskBox_TextChanged(object sender, EventArgs e)
        {
            Text = AskBox.Text;
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AskBox.Text) || string.IsNullOrWhiteSpace(AskBox.Text) || VariantList.CheckedItems.Count < 1)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void RemoveAllButt_Click(object sender, EventArgs e)
        {
            VariantList.Items.Clear();
        }

        private void RemoveButt_Click(object sender, EventArgs e)
        {
            if (VariantList.SelectedItems == null)
                return;

            foreach (ListViewItem item in VariantList.SelectedItems)
                VariantList.Items.Remove(item);
        }

        private void VariantList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if ((bool)VariantList.Tag)
                return;

            if (VariantList.CheckedItems.Count > 1)
            {
                MessageBox.Show("В данном тесте разрешен лишь один правильный вариант ответа на вопрос!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                e.Item.Checked = false;
                return;
            }
        }
    }
}