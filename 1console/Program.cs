using System;

namespace _1console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Задание 1 ");
                Console.Write("Введите A: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Радиус равен " + GetRadius(a));

                Console.WriteLine("Задание 2 ");
                Console.Write("Введите a: ");
                double a1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите c: ");
                double c = Convert.ToInt32(Console.ReadLine());
                if (Check(a1,b,c)) Console.Write("Треугольник прямоугольный");
                else Console.Write("Треугольник не прямоугольный");
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool Check(double a, double b, double c)
        {
            if (a * a + b * b == c * c) return true;
            return false;
        }

        private static double GetRadius(double a)
        {
            return (a * Math.Sqrt(3)) / 3;
        }
    }
}