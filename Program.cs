using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: демонстрация методов
            Console.WriteLine("Сумма чисел: " + Sum(5, 3));

            int number = 10;
            CheckNumber(number);

            // Задание 2: работа с классом Пользователь
            User user1 = new User();
            user1.Id = 1;
            user1.Name = "Валера";
            user1.Email = "Valera@mail.ru";
            user1.Age = 18;

            user1.PrintInfo();

            User user2 = new User
            {
                Id = 2,
                Name = "Мария",
                Email = "maria@yandex.ru",
                Age = 22
            };

            Console.WriteLine(user2.GetUserData());
        }

        // Public метод с возвращаемым значением
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Private метод без возвращаемого значения
        private static void CheckNumber(int num)
        {
            if (num > 0)
                Console.WriteLine("Число положительное");
            else if (num < 0)
                Console.WriteLine("Число отрицательное");
            else
                Console.WriteLine("Число равно нулю");
        }
    }

    // Класс Пользователь
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Имя: {Name}, Email: {Email}, Возраст: {Age}");
        }

        public string GetUserData()
        {
            return $"ID: {Id}, Имя: {Name}, Email: {Email}, Возраст: {Age}";
        }
    }

}
