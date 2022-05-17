namespace Tester
{
    public partial class ResultFm : Form
    {
        public ResultFm((string fname, string lname) names, int count, ParallelQuery<(string ask, (string name, bool state)[] variant)> result)
        {
            InitializeComponent();

            if (!result.Any())
            {
                ResultLabel.Text = $"Поздравляем, {names.fname} {names.lname} - прошел(а) тест на 100.00%";
                return;
            }

            static double cast(double counttest, double countfail) => (counttest - countfail) / counttest * 100.00;
            ResultLabel.Text = $"Поздравляем, {names.fname} {names.lname} - прошел(а) тест на " +
                               $"{Math.Round(cast(count, result.Count()), 2)}%. " +
                               $"Неправильных ответов - {result.Count()} из {count}";

            foreach ((string ask, (string, bool)[] variant) in result)
                AskTree.Nodes.Add(ask).Tag = variant;
        }

        private void AskTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            var with = QuestList.Items;
            with.Clear();

            foreach ((string name, bool state) in ((string, bool)[])e.Node.Tag)
                with.Add(name).Checked = state;
        }
    }
}