//tamrin 2 - amir malmir
using System;

namespace EvenOddCheck
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter an integer n:");
            string input = Console.ReadLine();
            int n = int.Parse(input);

           
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is even!"); 
            }
            else
            {
                Console.WriteLine(n + " is odd!"); 
            }

          
            Console.WriteLine("That's it! Press any key...");
            Console.ReadKey();
        }
    }

}
