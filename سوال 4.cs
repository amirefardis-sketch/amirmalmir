//tamrin 4 - amir malmir
using System;

namespace LemoineOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an odd non-prime integer n (greater than 5):");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            if (n % 2 == 0 || n <= 5 || IsPrime(n))
            {
                Console.WriteLine("n must be odd, >5, and not prime!");
                return;
            }

            bool found = false;
            for (int q = 2; q * q <= n; q++)
            {
                if (!IsPrime(q)) continue;

                for (int r = 2; r <= n / q; r++)
                {
                    if (!IsPrime(r)) continue;

                    if (p > 1 && IsPrime(p))
                    {
                        Console.WriteLine("Found: " + p + " + " + q + " * " + r + " = " + n);
                        found = true;
                        break;
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
