using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Struct
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("함수내 x:{0},y:{1}", x, y);
        }

        static void Main(string[] args)
        {
            //ref
            int x = 10;
            int y = 20;

            Console.WriteLine("초기상태");
            Swap(ref x, ref y);
            Console.WriteLine("Swap()함수 실행 후 x:{0},y:{1}", x, y);

            //out
            int a = 20, b = 3;
            Console.WriteLine($"a={a}, b={b}");
            Console.WriteLine("Divide()함수 실행 후");
            Divide(a, b, out int quotient, out int remainder);
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;

            Console.WriteLine("");
        }

    }
}
