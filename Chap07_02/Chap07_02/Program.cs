// 인터페이스
using System;

namespace Chap07_02
{
    interface IEmployee
    {
        string getName();
        void setName(string n);

        int getCounter();
    }
    public class Employee : IEmployee
    {
        public static int numberOfEmployees; 
        // static 키워드를 사용함으로써 객체 생성 없이 numberOfEmployees 필드를 사용 가능
        // ex) 클래스명.필드명 형태의 사용이 가능
        private string name;
        private int counter;

        public string getName() 
        {
            return name;        
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getCounter()
        {
            return counter;
        }

        // 생성자
        public Employee()
        {
            counter = ++counter + numberOfEmployees;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("직원 수 입력: ");
            Employee.numberOfEmployees = int.Parse(Console.ReadLine());

            // 직원 객체 생성
            Employee e1 = new Employee(); 
            Console.Write("신입 직원의 이름을 입력하세요: ");
            n = Console.ReadLine();
            e1.setName(n);

            Console.WriteLine("- 직원 정보 -");
            Console.WriteLine("직원 번호: {0}", e1.getCounter());
            Console.WriteLine("직원 이름: {0}", e1.getName());

        }
    }
}

// Interface : 약속
// 메소드, 프로퍼티, 이벤트, 인덱서만을 가질 수 있다.
// 클래스에게 상속이 가능하다, 인터페이스에게도 상속이 가능하다.
// 정의 부분만 표현하고, 구현 부분은 상속 받은 클래스에서 구현한다.
