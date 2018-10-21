using System;

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

                // James - I really like that your GetUserInput(), it seperates validation from 
                // the business logic if you will.  
                var num = GetUserInput();

                // James - I like that your if statements are on seperate lines, makes it way easier to ready,
                // although I have to WARN you, with your current logic, you will repeat messages for sure, because these
                // are just if statements, what if you don't want one of these conditions to fire off? I garuntee
                // that one of these at least will double message ;)
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

        public static uint GetUserInput()
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
