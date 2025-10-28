//tamrin 6 - amir malmir
using Systemusing System;

namespace PrimesGoldLemoineRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end m (m > n):");
            int m = int.Parse(Console.ReadLine());

            if (m <= n)
            {
                Console.WriteLine("m must be > n!");
                return;
            }

            Console.WriteLine("Primes between " + n + " and " + m + ":");
            for (int num = n; num <= m; num++)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\nGoldbach (for evens) and Lemoine (for odds non-prime):");
            for (int num = n; num <= m; num++)
            {
                if (num % 2 == 0 && num > 2)
                {
                    Console.WriteLine("Goldbach for " + num + ":");
                    bool foundOne = false;
                    for (int p1 = 2; p1 <= num / 2; p1++)
                    {
                        int p2 = num - p1;
                        if (IsPrime(p1) && IsPrime(p2))
                        {
                            Console.WriteLine("  " + p1 + " + " + p2);
                            foundOne = true;
                            break; 
                        }
                    }
                    if (!foundOne) Console.WriteLine("  No pair!");
                }
                else if (num % 2 == 1 && num > 5 && !IsPrime(num))
                {
                    Console.WriteLine("Lemoine for " + num + ":");
                    bool foundOne = false;
                    for (int q = 2; q * 3 <= num; q++)
                    {
                        if (!IsPrime(q)) continue;
                        for (int r = 2; r <= (num - 2) / q; r++)
                        {
                            if (!IsPrime(r)) continue;
                            int p = num - q * r;
                            if (IsPrime(p))
                            {
                                Console.WriteLine("  " + p + " + " + q + " * " + r);
                                foundOne = true;
                                break;
                            }
                        }
                        if (foundOne) break;
                    }
                    if (!foundOne) Console.WriteLine("  No triple!");
                }
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
