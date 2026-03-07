using System;

namespace ProgrammingTest
{
    internal class B4344_B1
    {
        static void Main(string[] args)
        {
            int c;
            c = int.Parse(Console.ReadLine());
            for(int i = 0; i < c; i++)
            {
                string[] s = Console.ReadLine().Split();
                int[] score = new int[int.Parse(s[0])];
                for(int j = 0; j < score.Length; j++)
                {
                    score[j] = int.Parse(s[j+1]);
                }
                int sum = 0;
                for (int j = 0; j < score.Length; j++)
                {
                    sum += score[j];
                }
                float avg = sum / score.Length;
                int cnt = 0;
                for(int j=0; j < score.Length; j++)
                {
                    if(score[j] > avg)
                    {
                        cnt++;
                    }
                }
                float ratio = (float)cnt / score.Length * 100;
                Console.WriteLine($"{ratio:F3}%");
            }
        }
    }
}
