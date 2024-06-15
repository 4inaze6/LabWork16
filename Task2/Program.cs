namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "Vadyan", Password = "12344321" };

            user.Notify += (sender, e) =>
            {
                Console.WriteLine($"Изменены данные пользователя со следующим логином: {user.Login}");
            };
            user.Login = "MiNiPeKa";
            user.Password = "password";
        }
    }
}
