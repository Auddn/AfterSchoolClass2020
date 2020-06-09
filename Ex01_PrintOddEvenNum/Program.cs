using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PrintOddEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sN;
            Console.WriteLine("정수를 입력하세요 > ");
            n = Console.Read();
            sN = Convert.ToInt32(n);

            if (sN == 0)
            {
                Console.WriteLine("0 입니다.");
            }
            else if (sN % 2 == 0 && sN != 0)
            {
                Console.WriteLine("짝수입니다.");
            }else
            {
                Console.WriteLine("홀수입니다.");
            }
        }
    }
}
