using System;

namespace Chap02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1바이트 = 8비트 
            byte a = 100;
            // byte 자료형의 size는 1바이트(8bit),
            // 표현 범위는 0 ~ 255, 0 ~ 2의 8승 - 1 -> 0
            sbyte b = 127;
            // byte 자료형의 size는 1바이트(8bit),
            // 표현 범위는 -128 ~ 127, -2의 7승 ~  2의 7승 - 1 -> 0
            short c = -5;
            // ushort 자료형의 size는 2바이트(16bit),
            // 표현 범위는 -32768 ~ 32767, -2의 15승 ~  2의 15승 - 1 -> 0
            ushort d = 200;
            // ushort 자료형의 size는 2바이트(16bit),
            // 표현 범위는 0 ~ 65535, 0 ~  2의 16승 - 1 -> 0
            int e = 70000;
            // int 자료형의 size는 4바이트(32bit),
            // 표현 범위는 -2의 31승 ~  2의 31승 - 1 
            uint f = 2500000000;
            // uint 자료형의 size는 4바이트(32bit),
            // 표현 범위는 0 ~  2의 32승 - 1 ( 42억)

            // long, ulong 각각 8바이트

            a = 255;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}

// 변수, 자료형, 값 형식, 참조 형식

// 변수 : 값을 저장할 때 사용 하는 식별자
// 자료형 : 정수, 실수, 문자 및 문자열, 논리 ( 참 / 거짓 )
// 값 형식 : 스택(stack) 메모리 공간 사용
// 참조 형식 : 힙(heap) 메모리 공간 사용
