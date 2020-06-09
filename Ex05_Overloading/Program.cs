using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Overloading
{
    class Program
    {
        static int plus(int a, int b)
        {
            return a + b;
        }

        static double plus(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(plus(1, 2));
            Console.WriteLine(plus(1.1, 1.2));
        }
    }
}
