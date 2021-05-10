// 객체 지향 언어 OOP, class, Constructor(생성자), Destructor(소멸자), Garbage Collector, Inheritance
using System;

namespace Chap06_01
{
    class Human // 클래스
    {
        // 생성자
        public Human()
        {
            Name = "";
            BloodType = "";
            Age = 0;
            Gender = "";
        }

        // 생성자 오버로딩
        public Human(string iName, string iGender) 
        {
            Name = iName;
            BloodType = "";
            Age = 0;
            Gender = iGender;
        }

        // 필드 
        public string Name; // public -> 다른 class에서 참조가능
        public string BloodType;
        public int Age;
        public string Gender;

        // 메소드
        public void Sleep() 
        {
            Console.WriteLine("코 잡니다~~");
        }
        public void Sleep(string iName)
        {
            Console.WriteLine(iName + " 아가가 코 잡니다~~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human DSKim = new Human();
            Human ITGO = new Human("아이티고", "여");

            DSKim.Name = "김두산";
            DSKim.Gender = "남";
            DSKim.Sleep(DSKim.Name);
            Console.WriteLine(DSKim.Name);
            Console.WriteLine(DSKim.Gender);

            Console.WriteLine(ITGO.Name);
            Console.WriteLine(ITGO.Gender);
            ITGO.Sleep();

        }
    }
}
