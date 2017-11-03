/*
    Разработать приложение, в котором бы сравнивалось
    население трёх столиц из разных стран. Причём стра-
    на бы обозначалась пространством имён, а город —
    классом в данном пространстве.
*/
using System;
using System.Linq;
using Ukraine;
using Russia;
using Belarus;

namespace HomeCaseCS_Lesson3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Cyties = new int[]
            {
                Ukraine.Kiev.Population(),
                Russia.Moscow.Population(),
                Belarus.Minsk.Population()
            };

            Console.WriteLine($"The largest city has: " +
                $"{Cyties.Max()} population");
            Console.WriteLine($"The smallest city has: " +
                $"{Cyties.Min()} population");

            Console.ReadKey();
        }
    }
}
