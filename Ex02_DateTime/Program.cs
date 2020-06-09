using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour >= 12)
            {

                Console.WriteLine("현재시각 오후 " + DateTime.Now.Hour + "시 입니다.");
            }else
            {

                Console.WriteLine("현재시각 오전" + DateTime.Now.Hour + "시 입니다.");
            }
        }
    }
}