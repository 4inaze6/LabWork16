using System.Text;

namespace Task5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormEvent_SearchFormEventHandler(string search, string replace)
        {
            mainTextBox.Text = mainTextBox.Text.Replace(search, replace);
        }

        private void mainButton_Click(object sender, EventArgs e)
        {  
            SearchForm searchForm = new SearchForm();
            searchForm.SearchFormEventHandler += FormEvent_SearchFormEventHandler;
            searchForm.ShowDialog();
        }
    }
}
