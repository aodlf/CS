using System;

namespace Chap02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 부동 소수점 float (4byte), double (8byte)
            // IEEE 754 부동 소수점 표현방식
            float f = 3.14f; // float 경우 뒤에 f
            double d = 3.14;

            // 문자, 문자열
            char c = '김';
            string s = "아이티고 김두산";

            // 논리 자료형 boolean
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b1&&b2);

            Console.WriteLine(c);
            Console.WriteLine(s);

            Console.WriteLine(f / 3.1f);
            Console.WriteLine(d / 3.1);
        }
    }
}

// 변수, 자료형, 값 형식, 참조 형식

// 변수 : 값을 저장할 때 사용 하는 식별자
// 자료형 : 정수, 실수, 문자 및 문자열, 논리 ( 참 / 거짓 )
// 값 형식 : 스택(stack) 메모리 공간 사용
// 참조 형식 : 힙(heap) 메모리 공간 사용
