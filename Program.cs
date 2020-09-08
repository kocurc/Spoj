using System;

namespace Spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int[] array = new int[howMany];

            for (int i = 0; i < howMany; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < howMany; i++)
            {
                if (array[i] == 1)
                {
                    Console.WriteLine("NIE");

                    continue;
                }

                bool isPrime = true;

                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
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
