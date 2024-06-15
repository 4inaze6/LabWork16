namespace Task2
{
    internal class User
    {
        private string login;

        private string password;

        public event EventHandler Notify;

        public string Login
        {
            get => login;
            set
            {
                if (login != value) 
                {
                    login = value;
                    Notify?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    Notify?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
