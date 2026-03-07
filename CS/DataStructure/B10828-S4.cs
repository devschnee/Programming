using System.Text;

// 스택
class B10828_S4
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    Stack<int> stack = new Stack<int>();
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < n; i++)
    {
      string[] s = Console.ReadLine().Split();
      string op = s[0];
      switch (op)
      {
        case "push":
          int num = int.Parse(s[1]);
          stack.Push(num);
          break;
        case "pop":
          sb.AppendLine(stack.Count == 0 ? "-1" : stack.Pop().ToString());
          break;
        case "empty":
          sb.AppendLine(stack.Count == 0 ? "1" : "0");
          break;
        case "top":
          sb.AppendLine(stack.Count == 0 ? "-1" : stack.Peek().ToString());
          break;
        case "size":
          sb.AppendLine(stack.Count.ToString());
          break;
      }
    }
    Console.WriteLine(sb);
  }
}
/*
// 스택
class B10828_S4
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    Stack<int> stack = new Stack<int>();
    for(int i = 0; i < n; i++)
    {
      string[] s = Console.ReadLine().Split();
      string op = s[0];
      switch (op)
      {
        case "push":
          int num = int.Parse(s[1]);
          stack.Push(num);
          break;
        case "pop":
          Console.WriteLine(stack.Count == 0 ? "-1" : stack.Pop().ToString());
          break;
        case "empty":
          Console.WriteLine(stack.Count == 0 ? "1" : "0");
          break;
        case "top":
          Console.WriteLine(stack.Count == 0 ? "-1" : stack.Peek().ToString());
          break;
        case "size":
          Console.WriteLine(stack.Count.ToString());
          break;
      }
    }
  }
}
*/