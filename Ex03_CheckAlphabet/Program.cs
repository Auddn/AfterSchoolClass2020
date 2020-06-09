using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CheckAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int asciiCode;
            char c1;

            Console.WriteLine("Enter the character");
            c1 = (char)Console.Read();
            asciiCode = Convert.ToInt32(c1);

            if ((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122))
            {
                Console.WriteLine(c1 + "는 알파벳 입니다.");
            } else
            {
                Console.WriteLine(c1 + "는 알파벳이 아닙니다.");
            }
        }
    }
}
