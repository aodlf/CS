// 반복문 do while, for each, break, continue
using System;

namespace Chap04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach 배열과 같은 컬렉션 개체를 다룰 때 사용되는 반복문
            string[] x = {"짜장면", "짬뽕", "탕수육"};
            int[] y = { 55, 7, 31, -9 };

            for (int j = 0; j < 4; j++)
            {
                if (j == 2) break;
                Console.WriteLine(y[j]);
            }

            for (int j = 0; j < 4; j++)
            {
                if (j == 2) continue;
                Console.WriteLine(y[j]);
            }

            /*
                        foreach (string i in x)
                        {
                            Console.WriteLine(i);
                        }


                        foreach (int j in y)
                        {
                            Console.WriteLine(j);
                        }
            */

            /*
                        string x;

                        do
                        {
                            Console.WriteLine("반복문 연습중...");
                            x = Console.ReadLine();
                        } while ((x != "q") && (x != "Q"));
            */
        }
    }
}
