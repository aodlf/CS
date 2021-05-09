// 삼항 연산자 (조건) ? 참 : 거짓
// 논리 연산자 !, &&, ||
using System;

namespace Chap03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            int z;
            bool b;
            string a;

            Console.WriteLine("{0} {1}", !false, !true);

            b = (x != y) && (x > y);
            // && 논리 And연산, 두 조건이 True일때 True
            b = (x != y) && (x > y);
            // || 논리 Or연산, 둘 중 한쪽 조건이 True이거나 두 조건이 True일때 True
            Console.WriteLine("{0} {1} {2}", (x != y), (x > y), b);

            z = (x > y) ? x : y; // (조건) ? 참 : 거짓
            Console.WriteLine(z);
            a = (x > y) ? "x가 큰 수" : "y가 큰 수";
            Console.WriteLine(a);
        }
    }
}
