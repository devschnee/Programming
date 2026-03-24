// B1181 S5 단어정렬
using System;
using System.Linq;
using System.Collections.Generic;
class Program{
  static void Main(){
    int n = int.Parse(Console.ReadLine());
    List<string> l = new List<string>();
    for(int i = 0; i < n; i++)
    {
      l.Add(Console.ReadLine());
    }
    l = l.Distinct().ToList();
    l.Sort((x, y) => x.Length != y.Length ? x.Length.CompareTo(y.Length) : x.CompareTo(y));
    for(int i = 0; i<l.Count; i++)
    {
      if (i == l.Count - 1)
      {
        Console.Write(l[i]);
      }
      else
        Console.WriteLine(l[i]);
    }
  }
}