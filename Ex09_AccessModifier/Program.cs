using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_AccessModifier
{
    class A
    {
        public int val1 = 10;
        protected int val2 = 20;
        private int val3 = 30;
    }

    class B : A
    {
        public int GetVal1()
        {
            return val1;
        }

        public int GetVal2()
        {
            return val2;
        }
    }

    class C : A
    {
        /*
        public int GetVal3()
        {
            return val3;
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Console.WriteLine($"a.val1 : {a.val1}");
            //Console.WriteLine($"a.val2 : {a.val2}");

            Console.WriteLine($"b.val1 : {b.GetVal1()}");
            Console.WriteLine($"b.val2 : {b.GetVal2()}");
        }
    }
}
