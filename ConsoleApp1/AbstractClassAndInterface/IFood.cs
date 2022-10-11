using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
     interface IFood
    {
        public abstract void cook();
        static readonly string laserPrinter = "Laser";
        static string LaserPrint()
        {
            return laserPrinter;
        } 
        public abstract void print(string info);

        public void printDefault()
        {
            Console.WriteLine("zijidelei");
        }
    }
}
