using System;

namespace Chap02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;        // 값 형식 변수, 중괄호가 끝나는 시점에 메모리에서 제거
            short d = 30000;   // 0111 0101 0011 0000(2)
            sbyte e = 127;
            int f;
            float g = 3.141592f;
            object b = "ITGO"; // 참조 형식 변수, GC 메모리에서 제거
            object c = 100;    // 참조 형식 변수, GC 메모리에서 제거
            //f = e;
            e = (sbyte)d; // 2바이트 자료형인 short을 sbyte 형으로 강제 형변환, Overflow발생
            // 0111 0101 0011 0000(2) -> 0011 0000(2)

            f = (int)g;   // float형 -> int형으로 강제 형변환, 소수점 부분이 잘려나감
            Console.WriteLine("{0} {1}", g, f);

            //Console.WriteLine("{0} {1} {2}", a, d, e);
            //Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}

// 값 형식 : 스택(stack) 메모리 공간 사용
// 참조 형식 : 힙(heap) 메모리 공간 사용