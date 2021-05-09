// 메소드 , 매개변수 전달 방식 , DS KIM

// 객체 지향 언어(OOP)에서 사용되는 용어
// return
// Recursive call
using System;

namespace Chap05_01
{
    class Dog
    {
        public static void Eat(string food)
        {
            Console.WriteLine(food + "를 맛있게 먹습니다. 냠냠~");
        }
        public static string Sleep()
        {
//            Console.WriteLine("쿨쿨");
            return "쿨쿨";
        }
    }

    class Program
    {
        public static void Nice()
        {
            Console.WriteLine("C# 재밌어요");
        }

        static void Main(string[] args)
        {
            Program.Nice();
            Dog.Eat("사료");
            Dog.Eat("개껌");
            Console.WriteLine(Dog.Sleep());
//            Dog.Sleep();
        }
    }
}
