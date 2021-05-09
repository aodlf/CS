// 연산자 (Operator)
using System;

namespace Chap03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            int y = 44;
            bool z;

            z = (x != y);
            Console.WriteLine(z);

            //int x = 55;
            //Console.WriteLine(x);
            ////x = x + 1;
            ////x += 1;
            ////x = x * 2;
            ////x *= 2;
            //Console.WriteLine(x);


            //int x = 55;
            //Console.WriteLine(x++); // x값 출력 후 x = x + 1
            //Console.WriteLine(++x); // x = x + 1 연산 후 x값 출력
            //Console.WriteLine(++x);
            //Console.WriteLine(x++);
            //Console.WriteLine(x);

            //int a = 55;
            //int b = 3;
            //b = 2;
            //++b; // b = b + 1
            //a++; // a = a + 1
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);
        }
    }
}
