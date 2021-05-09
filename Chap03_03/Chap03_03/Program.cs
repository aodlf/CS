// 비트 연산자 >>, <<, &, |, ^, ~
using System;

namespace Chap03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 61; 
            // 0000 0000 0000 0000 0000 0000 0011 1101(2)
            // 0    0    0    0    0    0    3    D(16)   

            int y = 55;
            // 0000 0000 0000 0000 0000 0000 0011 0111(2)
            // 0    0    0    0    0    0    3    7(16)   

            Console.WriteLine("{0} {1}",x, y);
            Console.WriteLine("{0:X8} {1:X8}",x, y);

            Console.WriteLine(x << 2);
            // 00 0000 0000 0000 0011 0111 00(2)
            // 128 + 64 + 32 + 16 + 4 = 244(10)

            Console.WriteLine(x >> 2);
            // 0000 0000 0000 0000 0011 1101(2)
            // 00000 0000 0000 0000 0011 110(2)
            // 00 0000 0000 0000 0000 0011 11(2)
            //                      2 4 8 16 = 30(10)

            // formatting

        }
    }
}
