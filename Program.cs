using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter your name: ");
                var userName = Console.ReadLine();
                Console.WriteLine($"Hello, {userName}. Enter a number between 1 and 100: ");
                var num = GetUserInput();

                if (num % 2 != 0)
                {
                    Console.WriteLine($"{num} and Odd.");
                }

                if ((num % 2 == 0) && num >= 2 && num <= 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }

                if ((num % 2 == 0) && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even.");
                }

                if ((num % 2 == 0) && num > 60)
                {
                    Console.WriteLine($"{num} and Even.");
                }

                if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine($"{num} and Odd.");
                }

                Console.WriteLine($"{userName}, do you want to continue? (y/n)");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }

        private static uint GetUserInput()
        {
            uint input;
            while (!uint.TryParse(Console.ReadLine(), out input) && input < 100)
            {
                Console.WriteLine("Please enter a positive number!");
                Console.WriteLine("Try again: ");
            }

            return input;
        }
    }
}
