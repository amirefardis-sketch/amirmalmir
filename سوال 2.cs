//tamrin 2 - amir malmir
using System;

namespace EvenOddCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple program to check if number is even or odd
            Console.WriteLine("Enter an integer n:");
            string input = Console.ReadLine();
            int n = int.Parse(input); // Get input as int

            // Use modulo operator to check
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is even!"); // Zoj
            }
            else
            {
                Console.WriteLine(n + " is odd!"); // Fard
            }

            // Just a fun message
            Console.WriteLine("That's it! Press any key...");
            Console.ReadKey();
        }
    }
}