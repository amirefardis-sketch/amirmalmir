//tamrin 1 - amir malmir

using System;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program to check if a number is prime
            Console.WriteLine("Enter a positive integer n:");
            string input = Console.ReadLine();
            int n = int.Parse(input); // Convert string to int

            // Check if n is less than 2, because primes start from 2
            if (n < 2)
            {
                Console.WriteLine("n is not a prime number!");
                return; // Exit the program
            }

            bool isPrime = true; // Assume it's prime at first
            // Loop from 2 to sqrt(n) to check divisors
            for (int i = 2; i * i <= n; i++) // Simple loop, no Math.Sqrt for beginner
            {
                if (n % i == 0) // If divisible, not prime
                {
                    isPrime = false;
                    break; // Stop the loop
                }
            }

            // Print the result
            if (isPrime)
            {
                Console.WriteLine("Yes, " + n + " is a prime number!");
            }
            else
            {
                Console.WriteLine("No, " + n + " is not a prime number!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
