using System;
using NewtonMethod;

namespace ConsoleUI
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            double number, power, accuracy;
            do
            {
                Console.WriteLine("Enter a number:");
            } while(!Double.TryParse(Console.ReadLine(), out number));
            do
            {
                Console.WriteLine("Enter a power:");
            } while (!Double.TryParse(Console.ReadLine(), out power));
            do
            {
                Console.WriteLine("Enter an accuracy:");
            } while (!Double.TryParse(Console.ReadLine(), out accuracy));
            Console.WriteLine("Newton Method: " + NewtonMethodClass.GetRootByNewtonMethod(power, number, accuracy));
            if (power != 0)
                power = 1 / power;
            Console.WriteLine("Math.Pow: " + Math.Pow(number,power));
            Console.ReadLine();
        }
    }
}
