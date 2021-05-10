using System;

namespace Chap07_01
{
    class Program
    {
        struct PointS // 클래스와 유사한 구문, 상속 불가, 인터페이스 구현 불가
        {
            public int x;
            public int y;

            public PointS(int x, int y) // 구조체의 생성자는 매개변수를 넣어 만들어야 한다
            {
                this.x = x;
                this.y = y;
            }
        }
        class PointC // 클래스
        {
            public int x;
            public int y;

            public PointC(int x, int y) // 구조체의 생성자는 매개변수를 넣어 만들어야 한다
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            PointS p1 = new PointS(1, 2);
            PointC p2 = new PointC(1, 2);
            PointS p3 = p1; // 값에 의한 복사
            PointC p4 = p2; // 참조에 의한 복사

            //Console.WriteLine("{0} {1}", p1.x, p1.y);
            //Console.WriteLine("{0} {1}", p2.x, p2.y);

            p3.x = 11;
            p4.x = 11;

            Console.WriteLine("{0} {1}", p1.x, p3.x);
            Console.WriteLine("{0} {1}", p2.x, p4.x);
        }
    }

    /*
        class Animal
        {
            private void A() { }
            protected void B() { }
            public void C() { }

            public void AnimalMethod()
            {
                A();
                B();
                C();
            }
        }
        class Human : Animal
        {
            public void HumanMethod()
            {
             // A();
             // private 접근 지시어로 선언된 메소드 접근은 같은 클래스 안에서만 접근 가능
                B(); 
             // protected 접근 지시어로 선언되었고 Human 클래스는 Animal 클래스의 파생 클래스이므로 접근 가능
                C();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int a = 10;
                Human itgo = new Human();
                itgo.HumanMethod();
                itgo.AnimalMethod();
                itgo.C();
              //itgo.B();
            }
    */



}