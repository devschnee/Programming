// 9253 스페셜 저지
using System;
class B9253_B2
{
  static void Main(string[] args)
  {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();

    if(a.Contains(c) && b.Contains(c))
    {
      Console.WriteLine("YES");
    }
    else
    {
      Console.WriteLine("NO");
    }
  }
}