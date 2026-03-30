using System;
using System.Text;

namespace Lab3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool menuRunning = true;

            while (menuRunning)
            {
                Console.Clear();
                Console.WriteLine(" 1. Завдання 1: Клас Triangle (Масив та сортування)");
                Console.WriteLine(" 2. Завдання 2: Ієрархія класів (Персона -> Інженер)");
                Console.WriteLine(" 0. Вихід з програми");
                Console.Write("\n Оберіть номер завдання: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Task1.Execute();
                        break;

                    case "2":
                        Console.Clear();
                        Task2.Execute();
                        break;

                    case "0":
                        menuRunning = false;
                        Console.WriteLine("\nПрограма завершена. Гарного дня!");
                        continue;

                    default:
                        Console.WriteLine("\n[Помилка] Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("Натисніть Enter, щоб повернутися до головного меню...");
                Console.ReadLine();
            }
        }
    }
}