//tamrin 3 - amir malmir
using System;

namespace GoldbachEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an even positive integer n (greater than 2):");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            if (n % 2 != 0 || n <= 2)
            {
                Console.WriteLine("n must be even and >2!");
                return;
            }

            bool found = false;
            for (int p1 = 2; p1 <= n / 2; p1++)
            {
                int p2 = n - p1;

                bool p1Prime = IsPrime(p1);
                bool p2Prime = IsPrime(p2);

                if (p1Prime && p2Prime)
                {
                    Console.WriteLine("Found: " + p1 + " + " + p2 + " = " + n);
                    found = true;
                    break; 
                }
            }

            if (!found)
            {
                Console.WriteLine("No pair found! (Should not happen for even n)");
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
