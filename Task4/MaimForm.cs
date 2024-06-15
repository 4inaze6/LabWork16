namespace Task4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DigitButtonOnClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            mainTextBox.Text += clickedButton.Text;
        }

        private void ClearButtonOnClick(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }

        private void ClearMinusOneButtonOnClick(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
        }
    }
}
