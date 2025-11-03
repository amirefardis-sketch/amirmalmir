using System;

namespace NumberFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            char continueChoice = 'y';
            do
            {
                int n = ReadInt("Adad n ra vared konid: ");
                int m = ReadInt("Adad m ra vared konid: ");

                if (n < 0 || m < 0)
                {
                    Console.WriteLine("Khata: n va m bayad gheyr-manfi bashand.");
                    continue;
                }

                if (n > m)
                {
                    Console.WriteLine("Tavajoh: n az m bozorg-tar bud; jabeja shod.");
                    int t = n; n = m; m = t;
                }

                Console.WriteLine("\nEntekhab konid:");
                Console.WriteLine("1: Zoj");
                Console.WriteLine("2: Fard");
                Console.WriteLine("3: Aval");
                Console.WriteLine("4: Ayinei");
                Console.WriteLine("5: Kamel");
                int choice = ReadInt("Gozine (1-5): ");
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Gozine namotabar! Dobare talash konid.");
                    continue;
                }

                Console.WriteLine($"\nAdadha-ye entekhabi dar baze [{n}, {m}]:");
                bool any = false;
                for (int i = n; i <= m; i++)
                {
                    bool matches = false;
                    switch (choice)
                    {
                        case 1: matches = IsEven(i); break;
                        case 2: matches = IsOdd(i); break;
                        case 3: matches = IsPrime(i); break;
                        case 4: matches = IsPalindrome(i); break;
                        case 5: matches = IsPerfect(i); break;
                    }
                    if (matches)
                    {
                        Console.Write(i + " ");
                        any = true;
                    }
                }
                if (!any) Console.Write("(Mowredi yaft nashod)");
                Console.WriteLine();

                Console.Write("Edame? (y/n): ");
                continueChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (continueChoice == 'y' || continueChoice == 'Y');
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                int val;
                if (int.TryParse(s, out val))
                    return val;

                Console.WriteLine("Voroodi namotabar! Lotfan adad sahih vared konid.");
            }
        }

        static bool IsEven(int x) => x % 2 == 0;
        static bool IsOdd(int x) => x % 2 != 0;

        static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            if (x <= 3) return true;
            if (x % 2 == 0 || x % 3 == 0) return false;
            for (int i = 5; i * i <= x; i += 6)
            {
                if (x % i == 0 || x % (i + 2) == 0) return false;
            }
            return true;
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string s = x.ToString();
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left++] != s[right--]) return false;
            }
            return true;
        }

        static bool IsPerfect(int x)
        {
            if (x <= 1) return false;
            int sum = 1;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    sum += i;
                    int other = x / i;
                    if (other != i) sum += other;
                }
            }
            return sum == x;
        }
    }
}
