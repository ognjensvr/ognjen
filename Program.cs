using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            for (int broj = 1; broj < 100; broj++)
            {
                if (broj % 5 == 0)
                {
                    Console.WriteLine($"Broj {broj} je deljiv sa 5");
                }
                else
                {
                    Console.WriteLine($"Broj {broj} nije deljiv sa 5");
                }
            }

            Console.ReadLine();
        }
    }
}
