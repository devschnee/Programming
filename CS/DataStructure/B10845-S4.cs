using System.Text;

class B10845_S4
{
  static void Main()
  {
    int a = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    Queue<int> q = new Queue<int>();
    int value = -1;
    for (int i = 0; i < a; i++)
    {
      string[] s = Console.ReadLine().Split();
      string op = s[0];
      switch (op)
      {
        case "push":
          value = int.Parse(s[1]);
          q.Enqueue(value);
          break;
        case "pop":
          sb.AppendLine(q.Count == 0 ? "-1" : q.Dequeue().ToString());
          break;
        case "size":
          sb.AppendLine(q.Count.ToString());
          break;
        case "empty":
          sb.AppendLine(q.Count == 0 ? "1" : "0");
          break;
        case "front":
          sb.AppendLine(q.Count == 0 ? "-1" : q.Peek().ToString());
          break;
        case "back":
          sb.AppendLine(q.Count == 0? "-1" : value.ToString());
          break;
      }
    }
    Console.Write(sb.ToString());
  }
}