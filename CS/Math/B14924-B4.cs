//B14924 폰 노이만과 파리
using System;
class B14924_B4
{
  static void Main()
  {
    string[] st = Console.ReadLine().Split();
    int S = int.Parse(st[0]);
    int T = int.Parse(st[1]);
    int D = int.Parse(st[2]);

    Console.WriteLine(T*(D/(S*2)));
  }
}