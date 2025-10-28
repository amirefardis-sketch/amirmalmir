//tamrin 1 - amir malmir

using System;

namespace PrimeCheck
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
                Console.WriteLine("n is not a prime number!");
                return; 
            }

            bool isPrime = true; 
            
            for (int i = 2; i * i <= n; i++) 
            {
                if (n % i == 0) 
                {
                    isPrime = false;
                    break; 
                }
            }

          
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

