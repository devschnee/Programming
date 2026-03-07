using System;
using System.Linq;

namespace ProgrammingTest
{
    internal class B17903_B4
    {
        static void Main(string[] args)
        {
            // Linq로 사용할 수 있는 기능(Select...ToArray...)
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = numbers[0];
            int n = numbers[1];

            if (m >= 8) Console.WriteLine("satisfactory");
            else Console.WriteLine("unsatisfactory");
        }
    }
}