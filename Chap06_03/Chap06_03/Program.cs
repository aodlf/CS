// OOP, 클래스, 생성자, 소멸자, 상속, 오버라이딩, 복사-3
using System;

namespace Chap06_03 
{

    //    class Animal
    //    {
    //        public void Eat(string food)
    //        {
    //            Console.WriteLine(food + " 를(을) 냠냠~~");
    //        }
    //        public virtual void Sleep()
    //        {
    //            Console.WriteLine("코 잡니다~~");
    //        }
    //        /*
    //                public void Sleep(string iName)
    //                {
    //                    Console.WriteLine(iName + " (이)가 코 잡니다~~");
    //                }
    //        */
    //    }
    //    class Human : Animal // 클래스
    //    {
    //        // 생성자
    //        public Human()
    //        {
    //            Name = "";
    //            BloodType = "";
    //            Age = 0;
    //            Gender = "";
    //        }

    //        // 생성자 오버로딩
    //        public Human(string Name, string iGender)
    //        {
    //            this.Name = Name;
    //            BloodType = "";
    //            Age = 0;
    //            Gender = iGender;
    //        }

    //        // 소멸자
    //        ~Human()
    //        {
    //            Console.WriteLine("소멸자 동작!");
    //        }

    //        // 필드 
    //        public string Name; // public -> 다른 class에서 참조가능
    //        public string BloodType;
    //        public int Age;
    //        public string Gender;

    //        // 메소드
    //        public override void Sleep() // 메소드 오버라이딩
    //        {
    //            Console.WriteLine("사람이 코 잡니다~~");
    //        }
    //    }
    //    sealed class Dog : Animal
    //    {
    //        public sealed override void Sleep() // 메소드 오버라이딩, Sealed 적용
    //        {
    //            Console.WriteLine("개가 코 잡니다~~");
    //        }
    //    }
    ///*
    //    // Dog 클래스는 sealed 키워드로 봉인 상태, 상속이 불가능 한 클래스
    //    class Puppy : Dog 
    //    {
    //        //public override void Sleep()
    //        //{
    //        //    Console.WriteLine("강아지가 코 잡니다~~");
    //        //}
    //    }
    //*/
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Human DSKim = new Human();
    //            Human ITGO = new Human("아이티고", "여");
    //            Dog Happy = new Dog();
    //           // Puppy Jenny = new Puppy();

    //            //Jenny.Sleep();
    //            Happy.Sleep();
    //            DSKim.Name = "김두산";
    //            DSKim.Gender = "남";
    //            //DSKim.Sleep(DSKim.Name);
    //            Console.WriteLine(DSKim.Name);
    //            Console.WriteLine(DSKim.Gender);

    //            Console.WriteLine(ITGO.Name);
    //            Console.WriteLine(ITGO.Gender);
    //            ITGO.Sleep();
    //            ITGO.Eat("바나나");
    //            Happy.Eat("사료");
    //            //Happy.Sleep("해피");


    //        }
    //    } 
    class TestCopy
    {
        public int x;
        public int y;

        public TestCopy HardCopy() // 깊은 복사 메소드
        {
            TestCopy newCopy = new TestCopy(); // 객체 생성
            newCopy.x = this.x;
            newCopy.y = this.y;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestCopy a = new TestCopy();
            a.x = 50;
            a.y = 99;
            Console.WriteLine("{0} {1}", a.x, a.y);

            TestCopy b = a; // Shallow Copy
            b.x = -9;
            Console.WriteLine("{0} {1}", a.x, a.y);
            Console.WriteLine("{0} {1}", b.x, b.y);



            TestCopy c = new TestCopy();
            c.x = 55;
            c.y = 3;
            Console.WriteLine("{0} {1}", c.x, c.y);

            TestCopy d = c.HardCopy(); // Deep Copy
            // d.x == 55, d.y == 3
            d.x = -99;
            Console.WriteLine("{0} {1}", c.x, c.y);
            Console.WriteLine("{0} {1}", d.x, d.y);
        }
    }
}
