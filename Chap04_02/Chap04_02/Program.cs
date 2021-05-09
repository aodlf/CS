// 반복문 for , while
using System;

namespace Chap04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string y;
            int i;

            y = Console.ReadLine(); // 키보드입력을 받음
            x = int.Parse(y);

            i = 1;
            while (i < 10)
            {
                Console.WriteLine("{0} * {1} = {2}", x, i, x * i);
                i++;
            }

            /*
                        int x;
                        string y;

                        y = Console.ReadLine(); // 키보드입력을 받음
                        x = int.Parse(y);

                        for(int i = 1; i < 10; i++)
                        {
                            Console.WriteLine("{0} * {1} = {2}", x, i, x * i);
                        }
            */

            //Console.WriteLine(x+7);

            /*
                        int x = 10;

                        // for(초기 값 ; 조건식 ; 증감식)
                        // i == 1 , 1 <= 10 , 2 = 1 + 1;
                        // i == 2 , 2 <= 10 , 3 = 2 + 1;
                        // i == 3 .....
                        // i == 10 , 10 <= 10 , 11 = 10 + 1;
                        // i == 11 , 11 <= 10 ------> 거짓 , 반복문 종료

                        for (int i = 1; i <= x; i++)          
                        {
                            Console.WriteLine(i);
                        }
            */
        }
    }
}
