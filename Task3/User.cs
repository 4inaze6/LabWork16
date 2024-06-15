namespace Task3
{
    internal class User
    {
        private string login;

        private string password;

        public event EventHandler<InfoEventArgs> Notify;

        public string Login
        {
            get => login;
            set
            {
                if (login != value)
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        login = value;
                    ShowNotify("login", value);
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
                    if (value.Length >= 6 && value.Length <= 20)
                        password = value;
                    ShowNotify("password", value);
                }
            }
        }

        void ShowNotify(string propertyName, string value)
        {
            string errorText = "";
            if (propertyName == "login")
            {
                if (string.IsNullOrWhiteSpace(value))
                    errorText = " логин не может быть пустым, изменение не удалось";
            }
            else if (propertyName == "password")
            {
                if (value.Length < 6 || value.Length > 20)
                    errorText = " пароль не может быть меньше 6 или больше 20 символов, изменение не удалось";
            }
            Notify?.Invoke(this, new InfoEventArgs(propertyName, errorText, DateTime.Now));
        }
    }
}
