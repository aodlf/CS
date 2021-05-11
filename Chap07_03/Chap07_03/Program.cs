// 추상클래스
using System;

namespace Chap07_03
{
    public abstract class Employee
    {
        protected string name;                     // 추상클래스는 인터페이스와 달리 필드 선언이 가능
        public Employee(string name)               // 생성자
        {
            this.name = name;
        }
        public abstract void Display();            // 추상메소드, 상속받은 클래스는 반드시 이 메소드를 구현해야 한다.
    }
    public class Manager : Employee
    {
        public Manager(string name) : base(name)   // base 키워드는 부모 클래스의 생성자를 호출
        {
            
        }
        public override void Display()             // 추상메소드 재정의
        {
            Console.WriteLine("성명은 : " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("고아이티");
            m1.Display();
//          Console.WriteLine(m1.name);
            Employee e1 = new Manager("김두산");
            e1.Display();
        }
    }
}

// abstract : 인터페이스와 클래스 중간
// 인터페이스와 달리 구현 부분을 가질 수 있다.
// 클래스와 달리 인스턴스를 가질 수 없다.