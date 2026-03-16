using System;
using System.Text;
// 사과와 바나나 나눠주기
class B14914_B3
{
  static void Main(string[] args)
  {
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);

    StringBuilder sb = new StringBuilder();
    for(int i = 1; i <= Math.Min(a, b); i++)
    {
      if(a % i == 0 && b % i == 0)
      {
        sb.AppendLine($"{i} {a/i} {b/i}");
      }
    }
    Console.WriteLine(sb.ToString());
  
  }
}