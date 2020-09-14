using System;

namespace Spoj2
{
    class Program
    {
        // https://pl.spoj.com/problems/FCTRL3/
        static void Main(string[] args)
        {
            int howManyNumbers = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[howManyNumbers];
            int[] factorials = new int[howManyNumbers];

            for (int i = 0; i < howManyNumbers; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < howManyNumbers; i++)
            {
                if (numbersArray[i] > 9)
                {
                    factorials[i] = 0;
                }
                else if (numbersArray[i] == 0)
                {
                    factorials[i] = 1;
                }
                else
                {
                    factorials[i] = numbersArray[i];

                    for (int j = numbersArray[i]; j > 1; j--)
                    {
                        factorials[i] *= j - 1;
                    }
                }
            }

            for (int i = 0; i < factorials.Length; i++)
            {
                Console.Write((factorials[i] % 100) / 10);
                Console.Write(" ");
                Console.WriteLine(factorials[i] % 10);
            }

            watch.Stop();

            var elapsedTime = watch.ElapsedMilliseconds;

            // Console.WriteLine("Time: " + elapsedTime);
        }
    }
}
