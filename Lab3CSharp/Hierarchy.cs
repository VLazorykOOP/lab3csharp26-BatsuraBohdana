using System;

namespace Lab3CSharp
{
    // 1. Базовий клас
    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persona(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Show()
        {
            Console.Write($"[Персона] Ім'я: {Name}, Вік: {Age}");
        }
    }

    // 2. Службовець (Employee) успадковує Персону
    public class Employee : Persona
    {
        public string Department { get; set; }

        public Employee(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($", Відділ: {Department}");
        }
    }

    // 3. Робітник (Worker) успадковує Службовця
    public class Worker : Employee
    {
        public int SkillLevel { get; set; }

        public Worker(string name, int age, string department, int skillLevel) 
            : base(name, age, department)
        {
            SkillLevel = skillLevel;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($", Розряд: {SkillLevel} (Робітник)");
        }
    }

    // 4. Інженер (Engineer) успадковує Службовця
    public class Engineer : Employee
    {
        public string Specialization { get; set; }

        public Engineer(string name, int age, string department, string specialization) 
            : base(name, age, department)
        {
            Specialization = specialization;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($", Спеціалізація: {Specialization} (Інженер)");
        }
    }
}