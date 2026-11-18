using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП2
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        private double Dev(double a, double b)
        {
            if (b == 0) return 0; 
            return a / b;
        }
        public void ShowDivision(double a, double b)
        {
            double result = Dev(a, b);
            Console.WriteLine($"Частное: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("--- Проверка методов ---");
            Console.WriteLine($"Сумма: {calc.Add(10, 5)}");
            calc.ShowDivision(10, 2); 

            Console.WriteLine("\n--- Проверка класса User ---");
            User myUser = new User
            {
                Id = 1,
                Name = "Амра",
                Email = "amkaeamraa9@gmail.com",
                Password = "Amkkae1234",
                RegistrationDate = DateTime.Now
            };
            Console.WriteLine($"Пользователь: {myUser.Name}, Email: {myUser.Email}, Дата регистрации: {myUser.RegistrationDate}");

            Console.ReadLine();
        }
    }
}
