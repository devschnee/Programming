using System;

namespace ProgrammingTest
{
    // 벌집
    internal class B2292_B2
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            // 1번 방은 언제나 1
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            long maxRoom = 1;    // 층의 가장 큰 방 번호
            int roomCnt = 1;  // 지나가는 층(방) 수

            // N이 현재 층의 최대 번호보다 클 때까지 반복
            while (maxRoom < n)
            {
                // 다음 층의 최대 번호 = 현재 최대 번호 + (6 * 현재까지의 층수). 층이 증가 할 때마다 6의 배수만큼 더해짐. 1 + 6 + 12 + 18 + 24 + ...
                maxRoom += 6 * roomCnt;
                roomCnt++;
            }

            Console.WriteLine(roomCnt);
        }
    }
}