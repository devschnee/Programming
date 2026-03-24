// B1834 math 나머지와 몫이 같은 수
class B1834_B1
{
    static void Main()
    {
        // 자연수 x를 n으로 나눴을 때, 목 : q, 나머지 : r
        // x = n*q+r = n*r+r = r(n+1)
        long n = long.Parse(Console.ReadLine());
        // (n + 1) * n * (n - 1) / 2
        long sum = (n + 1) * (n - 1) * n / 2;
        Console.WriteLine(sum);
    }
}