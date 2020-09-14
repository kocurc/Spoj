using System;

namespace Spoj
{
    class Program
    {
        // https://pl.spoj.com/problems/PRIME_T/
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int[] tablica = new int[howMany];

            for (int i = 0; i < howMany; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < howMany; i++)
            {
                if (tablica[i] == 1)
                {
                    Console.WriteLine("NIE");

                    continue;
                }

                bool isPrime = true;

                for (int j = 2; j < tablica[i]; j++)
                {
                    if (tablica[i] % j == 0)
                    {
                        isPrime = false;
                        Console.WriteLine("NIE");

                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("TAK");
                }
            }
        }
    }
}