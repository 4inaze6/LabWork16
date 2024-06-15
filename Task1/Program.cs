using System.ComponentModel;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "Vadyan", Password = "12344321" };

            user.PropertyChanged += (sender, e) =>
            {
                Console.WriteLine($"{e.PropertyName} изменен");
            };

            user.Login = "1234";
            user.Login = "07931505";
            user.Password = "word";
        }
    }
}