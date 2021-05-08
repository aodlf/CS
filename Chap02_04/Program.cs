using System;

namespace Chap02_04
{
    class Program
    {
        enum Human { Warrior, Wizard=55, Thief} // 열거식
        static void Main(string[] args)
        {
            var x = -55.7; // var 키워드 사용시 변수를 선언과 동시에 초기화 해주어야 한다  , 초기화할때 자료형이 결정됨
            var y = "DS KIM"; // string
            var z = 9; // int
            object a = 3.7; // 다양한 값 가능. 참조형 타입 변수
            a = 5;
            a = "ITGO";
            z = (int)11.7;
            Console.WriteLine("{3} {0} {1} {2}", x.GetType(), y.GetType(), z.GetType(), a.GetType());
            //Console.WriteLine("{3} {0} {1} {2}", x,y,z,a);
            //Console.WriteLine((int)Human.Wizard);
            //Console.WriteLine(Human.Thief);
            //Console.WriteLine((int)Human.Warrior); // -> 0
        }
    }
}
