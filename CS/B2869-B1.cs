using System;
using System.Linq;

namespace ProgrammingTest
{
    // 달팽이는 올라가고 싶다
    internal class B2869_B1
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = nums[0];
            int b = nums[1];
            int v = nums[2];
            // 마지막 날에는 -b만큼 안 갈 것이기 때문에(+a해서 최고 높이 도달) 실질적으로 가야 하는 거리는 v-b
            // 정수 나눗셈은 버림을 하지만 여기서는 올림(Ceiling)을 해야하기 때문에 -1(나머지가 0인 경우 결과값이 1 커지는 것을 방지)
            // 하루에 실질적으로 갈 수 있는 거리는 a-b
            // 마지막 날 +a 하는 것을 +1(날짜)
            // (실제 올라야 하는 거리) / (하루 이동량) => 일수 나옴. 여기에 + 1(마지막 날 일수. +a만 오르는 날)
            int day = (v-b-1)/(a-b)+1;
            Console.WriteLine(day);
        }
    }
}
