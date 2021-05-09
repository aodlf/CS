using System;

namespace Chap04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 5;

            if (z == 1) Console.WriteLine("숫자 1입니다.");
            else if (z == 10) Console.WriteLine("숫자 10입니다.");
            else Console.WriteLine("case에 없는 값일 때 실행!");

            //switch(z)
            //{
            //    case 1:
            //        Console.WriteLine("숫자 1입니다.");
            //        break; // 탈출문
            //    case 10:
            //        Console.WriteLine("숫자 10입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("case에 없는 값일 때 실행!");
            //        break;
            //}

            //int x = 3, y = 7;

            //if (x > 7)          
            //    Console.WriteLine("if문이 참이면 실행!");
            //else if(x != y)
            //    Console.WriteLine("첫번째 if문이 False일때, 2번째 if문이 True일때 실행!");
            //else
            //    Console.WriteLine("이곳은 출력이 될까요???");           
        }
    }
}
