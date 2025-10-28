//tamrin 5 - amir malmir
using System;
using System;

namespace EvenOddPrimeGoldLemoine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer n:");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            if (n < 2)
            {
                Console.WriteLine("n too small!");
                return;
            }

            bool isPrime = IsPrime(n);
            string type = "";
            if (n % 2 == 0)
            {
                type = "even";
                if (isPrime) type += " prime (only 2 is even prime)";
            }
            else
            {
                type = "odd";
                if (isPrime) type += " prime";
            }

            Console.WriteLine(n + " is " + type + ".");

            if (n % 2 == 0)
            {
                Console.WriteLine("Goldbach for " + n + ":");
                for (int p1 = 2; p1 <= n / 2; p1++)
                {
                    int p2 = n - p1;
                    if (IsPrime(p1) && IsPrime(p2))
                    {
                        Console.WriteLine(p1 + " + " + p2);
                    }
                }
            }
            else if (!isPrime)
            {
                Console.WriteLine("Lemoine for " + n + ":");
                bool found = false;
                for (int q = 2; q * 3 <= n; q++)
                {
                    if (!IsPrime(q)) continue;
                    for (int r = 2; r <= (n - 2) / q; r++)
                    {
                        if (!IsPrime(r)) continue;
                        int p = n - q * r;
                        if (IsPrime(p))
                        {
                            Console.WriteLine(p + " + " + q + " * " + r);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
            }
            else
            {
                Console.WriteLine("It's an odd prime, no Goldbach/Lemoine needed.");
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

}
