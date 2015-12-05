using System;
using NewtonMethod;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, power;
            do
            {
                Console.WriteLine("Enter a number:");
            } while(!Double.TryParse(Console.ReadLine(), out number));

            do
            {
                Console.WriteLine("Enter a power:");
            } while (!Double.TryParse(Console.ReadLine(), out power));
            Console.WriteLine("Newton Method: " + NewtonMethodClass.GetRootByNewtonMethod(power, number));
            if (power != 0)
                power = 1 / power;
            Console.WriteLine("Math.Pow: " + (double) Math.Pow(number,power));
            Console.ReadLine();
        }
    }
}
