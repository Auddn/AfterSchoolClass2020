using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex07_ObjCoding
{
    class Cube
    {
        int x, y, z;
        static int countOfInstance;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            countOfInstance++;
        }

        public int GetVolume()
        {
            return x * y * z;
        }

        public int GetcountOfInstance()
        {
            return countOfInstance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Cube cube1 = new Cube(1, 2, 5);

            Console.WriteLine($"Cube의 부피 = {cube1.GetVolume()}");
            Console.WriteLine($"Cube의 갯수 = {cube1.GetcountOfInstance()}");
        }
    }
}
