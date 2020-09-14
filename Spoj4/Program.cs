using System;

namespace Spoj4
{
    class Program
    {
        // https://pl.spoj.com/problems/VSR/
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int[] averageVelocities = new int[howMany];

            for (int i = 0; i < howMany; i++)
            {
                int firstVelocity = int.Parse(Console.ReadLine());
                int secondVelocity = int.Parse(Console.ReadLine());

                averageVelocities[i] = (firstVelocity + secondVelocity) / 2;
            }

            for (int i = 0; i < howMany; i++)
            {
                Console.WriteLine(averageVelocities[i]);
            }
        }
    }
}
