// 메소드 , Recursive call 재귀호출(자신)
using System;

namespace Chap05_02
{
    class Program
    {
        // 5! = 5 * 4 * 3 * 2 * 1
        // 120
        // 6! = 6 * 5 * 4 * 3 * 2 * 1
        // 720
        static int Fact1(int n) // 팩토리얼 계산 메소드1, 반복문(for) 이용
        {
            int s = 1;
            for(int i = n; i > 0; i--)
            {
                s = s * i;
                //   5 =  1 * 5
                //  20 =  5 * 4
                //  60 = 20 * 3
                // 120 = 60 * 2
                // 120 = 60 * 1
            }
            return s;
        }
        static int Fact2(int n) // 팩토리얼 계산 메소드2, 재귀호출 이용
        {
            if (n <= 1) return 1;
            return n * Fact2(n - 1);
            // 5 * Fact2(4)
            // 5 * 4 * Fact2(3)
            // 5 * 4 * 3 * Fact2(2)
            // 5 * 4 * 3 * 2 * Fact2(1)
            // 5 * 4 * 3 * 2 * 1
            // 5! = 120
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fact1(5));
            Console.WriteLine(Fact2(5));
        }
    }
}
