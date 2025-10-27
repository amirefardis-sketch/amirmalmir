//tamrin 4 - amir malmir
using System;

namespace LemoineOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for odd n (not prime): find primes p, q, r where p + q * r = n
            Console.WriteLine("Enter an odd non-prime integer n (greater than 5):");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            // Quick checks
            if (n % 2 == 0 || n <= 5 || IsPrime(n))
            {
                Console.WriteLine("n must be odd, >5, and not prime!");
                return;
            }

            bool found = false;
            // Loop for q (multiplier prime)
            for (int q = 2; q * q <= n; q++) // q up to sqrt(n) roughly
            {
                if (!IsPrime(q)) continue;

                // Loop for r (another prime)
                for (int r = 2; r <= n / q; r++)
                {
                    if (!IsPrime(r)) continue;

                    int p = n - (q * r); // Calculate p

                    if (p > 1 && IsPrime(p))
                    {
                        Console.WriteLine("Found: " + p + " + " + q + " * " + r + " = " + n);
                        found = true;
                        break; // Find one triple
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine("No triple found!");
            }

            Console.ReadKey();
        }

        // Same prime check as before
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
}}