// 17263 Sort 마스터 배지훈
using System;
class B17623_B3
{
  static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    
    // Array 버전
    int[] arr = new int[n];

    string[] s = Console.ReadLine().Split();
    for(int i = 0; i < s.Length; i++)
    {
      arr[i] = int.Parse(s[i]);
    }

    Array.Sort(arr);
    Console.WriteLine(arr[n-1]);
    

    // List 버전

    // List<int> list = new List<int>();
    // string[] s = Console.ReadLine().Split();
    // for(int i = 0; i < s.Length; i++)
    // {
    //   list.Add(int.Parse(s[i]));
    // }
    // list.Sort();
    // Console.WriteLine(list[n-1]);
  }
}