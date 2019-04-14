using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press first number:\n");

            double first_age = Convert.ToDouble(Console.ReadLine());

            Console.Write("Press second number:\n");

            double second_age = Convert.ToDouble(Console.ReadLine());

            Result(first_age, second_age);
        }

        static void Result(double x,double y)
        {
            double result = x * y;

            Console.WriteLine($"Your result is - {result}");
            Console.ReadKey();
        }
    }
}