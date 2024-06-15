namespace Task5
{
    public delegate void EventHandler(string search, string replace);
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public event EventHandler SearchFormEventHandler;

        private void replaceButton_Click(object sender, EventArgs e)
        {
            SearchFormEventHandler?.Invoke(searchTextBox.Text, replaceTextBox.Text);
        }
    }
}
