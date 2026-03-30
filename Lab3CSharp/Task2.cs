using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3CSharp
{
    public static class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("\n--- Завдання 2: Ієрархія класів ---");

            // Створюємо масив базового класу Persona
            List<Persona> people = new List<Persona>();

            // Наповнюємо різними об'єктами
            people.Add(new Persona("Олена", 20));
            people.Add(new Engineer("Богдана", 19, "IT", "Software Developer"));
            people.Add(new Worker("Іван", 35, "Цех №1", 5));
            people.Add(new Employee("Андрій", 28, "Бухгалтерія"));
            people.Add(new Engineer("Максим", 25, "Design", "UI/UX Designer"));
            people.Add(new Worker("Степан", 40, "Склад", 3));

            // Сортування за типом об'єкта
            var sortedPeople = people.OrderBy(p => p.GetType().Name);

            Console.WriteLine("\nСписок об'єктів (впорядкований за типом):");
            foreach (var p in sortedPeople)
            {
                p.Show();
                Console.WriteLine();
            }
        }
    }
}