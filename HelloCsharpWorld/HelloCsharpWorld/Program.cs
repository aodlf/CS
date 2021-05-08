using System;
using System.Collections.Generic; // 폴더의 경로
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCsharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕 C# 월드");               
            Console.WriteLine("Hello C# World!"); // Line : 줄바꿈 기능
            Console.WriteLine("{0} {1}", args[1], args.Length);
        }
    }
}
