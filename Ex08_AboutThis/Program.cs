using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_AboutThis
{
    class AboutThis
    {
        int a, b, c;

        public AboutThis()
        {
            a = 1;
            Console.WriteLine("AboutThis() 호출");
        }
        public AboutThis(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"AboutThis({b}) 호출");
        }
        public AboutThis(int b, int c) : this()
        {
            this.b = b;
            Console.WriteLine($"AboutThis({b}) 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 미완성 코드
        }
    }
}
