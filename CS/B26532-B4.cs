using System;
using System.Linq;

namespace ProgrammingTest
{
    // Acres
    internal class B26532_B4
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            float w = numbers[0];
            float h = numbers[1];

            int bags = (int)Math.Ceiling(w * h / 4840 / 5);

            Console.WriteLine(bags);
        }
    }
}