//tamrin 3 - amir malmir
using System;

namespace GoldbachEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for Goldbach: find two primes that sum to even n
            Console.WriteLine("Enter an even positive integer n (greater than 2):");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            // Check if even
            if (n % 2 != 0 || n <= 2)
            {
                Console.WriteLine("n must be even and >2!");
                return;
            }

            bool found = false; // Flag to see if we found pair
            // Loop through possible first prime (from 2 to n/2)
            for (int p1 = 2; p1 <= n / 2; p1++)
            {
                int p2 = n - p1; // Second prime candidate

                // Simple prime check function (I wrote it inline for beginner style)
                bool p1Prime = IsPrime(p1);
                bool p2Prime = IsPrime(p2);

                if (p1Prime && p2Prime)
                {
                    Console.WriteLine("Found: " + p1 + " + " + p2 + " = " + n);
                    found = true;
                    break; // Just find one pair
                }
            }

            if (!found)
            {
                Console.WriteLine("No pair found! (Should not happen for even n)");
            }

            Console.ReadKey();
        }

        // Helper function to check prime (simple for beginner)
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}