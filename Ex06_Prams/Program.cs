using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ex06_Prams
{
    class Program
    {
        private static int Sum(params int[] args)
        {
            int sum = 0;
            Console.WriteLine("매개변수 : ");
            foreach (var item in args)
            {
                sum += item;
                Console.WriteLine(item + " ");
            }
        }

        private static void PrintProfile(string name, string phone = "전화번호 모름")
        {
            Console.WriteLine($"name : {name}, phone : {phone}");
        }
        static void Main(string[] args)
        {
            //가변길이
            Console.WriteLine($"Sum() : {Sum(1, 2, 3, 4, 5)}");
            Console.WriteLine($"Sum() : {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            //선택적
            PrintProfile("박명우", "010-0000-0000");
            PrintProfile("???");
        }
    }
}
