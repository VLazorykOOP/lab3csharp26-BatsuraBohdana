using System;
using System.Linq;

namespace Lab3CSharp
{
    public static class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("\n--- Завдання 1: Масив Трикутників ---");

            // Створюємо масив з 4 трикутників
            Triangle[] triangles = new Triangle[]
            {
                new Triangle(3, 4, 5, 10),  // Колір 10
                new Triangle(10, 10, 12, 5),// Колір 5
                new Triangle(6, 8, 10, 1),  // Колір 1
                new Triangle(5, 5, 5, 8)    // Колір 8
            };

            Console.WriteLine("\n1. Впорядковані за КОЛЬОРОМ:");
            foreach (var t in triangles.OrderBy(x => x.Color)) Console.WriteLine(t);

            Console.WriteLine("\n2. Впорядковані за ПЛОЩЕЮ:");
            foreach (var t in triangles.OrderBy(x => x.GetArea())) Console.WriteLine(t);

            Console.WriteLine("\n3. Впорядковані за ПЕРИМЕТРОМ:");
            foreach (var t in triangles.OrderBy(x => x.GetPerimeter())) Console.WriteLine(t);
        }
    }
}