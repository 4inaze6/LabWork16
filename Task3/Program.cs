namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "Vadyan", Password = "MiNiPeKa" };
            user.Notify += (sender, e) =>
            {
                Console.WriteLine($"{e.EditionDate}: у пользователя {user.Login} изменено {e.PropertyName}.\nОшибка:{e.ErrorText}.");
            };
            user.Login = "";
            user.Password = "e";
        }
    }
}
