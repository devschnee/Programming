using System.Text;

class B9012_S4
{
  static void Main()
  {
    int T = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < T; i++)
    {
      string str = Console.ReadLine();
      sb.Append(IsVPS(str) ? "YES\n" : "NO\n");
    }
    Console.Write(sb);
  }

  static bool IsVPS(string str)
  {
    int cnt = 0;
    foreach (char c in str)
    {
      if (c == '(')
        cnt++;
      else if (c == ')')
        cnt--;
      if (cnt < 0)
        return false;
    }
    return cnt == 0;
  }
}