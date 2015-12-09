using System;
using NewtonMethod;

namespace ConsoleUI
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            double number, accuracy;
            int power;
            do
            {
                Console.WriteLine("Enter a number:");
            } while(!Double.TryParse(Console.ReadLine(), out number));
            do
            {
                Console.WriteLine("Enter a power:");
            } while (!Int32.TryParse(Console.ReadLine(), out power));
            do
            {
                Console.WriteLine("Enter an accuracy (should be > 0):");
            } while (!Double.TryParse(Console.ReadLine(), out accuracy) || accuracy <= 0);
            Console.WriteLine("Newton Method: " + NewtonMethodClass.GetRootByNewtonMethod(power, number, accuracy));
            if (power != 0)
                power = 1 / power;
            Console.WriteLine("Math.Pow: " + Math.Pow(number,power));
            Console.ReadLine();
        }
    }
}
