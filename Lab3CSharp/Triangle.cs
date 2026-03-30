using System;

namespace Lab3CSharp
{
    public class Triangle
    {
        protected int a, b, c;
        protected int color;

        // Конструктор
        public Triangle(int sideA, int sideB, int sideC, int triangleColor)
        {
            // Перевірка при створенні: якщо трикутник не існує, ставимо дефолтні 3,4,5
            if (IsValid(sideA, sideB, sideC))
            {
                a = sideA; b = sideB; c = sideC;
            }
            else
            {
                a = 3; b = 4; c = 5;
            }
            color = triangleColor;
        }

        // Властивості (читання і запис)
        public int SideA
        {
            get => a;
            set { if (IsValid(value, b, c)) a = value; }
        }
        public int SideB
        {
            get => b;
            set { if (IsValid(a, value, c)) b = value; }
        }
        public int SideC
        {
            get => c;
            set { if (IsValid(a, b, value)) c = value; }
        }

        // Властивість кольору (тільки читання)
        public int Color => color;

        // Метод перевірки умови існування трикутника
        private bool IsValid(int sa, int sb, int sc)
        {
            return (sa + sb > sc) && (sa + sc > sb) && (sb + sc > sa);
        }

        public void PrintSides() => Console.WriteLine($"Сторони: {a}, {b}, {c}");

        public int GetPerimeter() => a + b + c;

        public double GetArea()
        {
            double p = GetPerimeter() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
        public override string ToString()
        {
            return $"Трикутник [Колір: {color}, Сторони: {a},{b},{c}, P: {GetPerimeter()}, S: {GetArea():F2}]";
        }
    }
}