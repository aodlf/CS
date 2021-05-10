// 매개변수 전달 방식 Call by value, Call by reference (ref keyword), Named parameter, Optional parameter
using System;

namespace Chap05_03
{
    class Program
    {
        // Optional Parameter
        static void Animal(string type, string gender = "")
        {
            Console.WriteLine("종류 : {0} / 성별 : {1}", type, gender);
        }
        static void Main(string[] args)
        {
            Animal("강아지");
            Animal("고양이", "암컷");
            Animal(gender: "수컷", type: "돼지이");
        }

        /*
                // Named Parameter
                static void Animal(string type, string gender)
                {
                    Console.WriteLine("종류 : {0} / 성별 : {1}", type, gender);
                }
                static void Main(string[] args)
                {
                    Animal("강아지", "수컷");
                    Animal("고양이", "암컷");
                    Animal(gender : "수컷", type : "돼지");
                }
        */

        /*
                static void Change(ref int c, ref int d) // c는 a를 참조, d는 b를 참조
                {
                    int t;
                    t = c; // main 메소드의 a의 값을 지역변수 t에 할당, t는 55
                    c = d; // main 메소드의 b의 값을 main 메소드에 있는 변수 a에 대입
                    d = t; // 지역변수 t에 들어있는 55를 main 메소드의 b 변수에 대입
                    Console.WriteLine("{0} {1}", c, d);
                }
                static void Main(string[] args)
                {
                    int a = 55, b = -9;

                    Console.WriteLine("{0} {1}", a, b);
                    Change(ref a, ref b); // 참조에 의한 호출
                    Console.WriteLine("{0} {1}", a, b);
        */

        /*
                static void Change(int c, int d) // c = a, d = b
                {
                    int t;
                    t = c; // t == 55
                    c = d; // c == -9
                    d = t; // d == 55
                    Console.WriteLine("{0} {1}", c, d);
                }
                static void Main(string[] args)
                {
                    int a = 55, b = -9;

                    Console.WriteLine("{0} {1}", a, b);
                    Change(a, b); // 값에 의한 호출
                    Console.WriteLine("{0} {1}", a, b);
        
        }
        */
    }
}
