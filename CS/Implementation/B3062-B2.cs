// B3062 수 뒤집기
using System;
using System.Linq;
class B3062_B2
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for(int i = 0; i < t; i++)
        {
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
            string nReversed = new string(arr);

            int sum = int.Parse(n) + int.Parse(nReversed);
            string sumStr = sum.ToString();
            string sumReversed = new string(sumStr.Reverse().ToArray());
            if (sumStr == sumReversed)
            {
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}