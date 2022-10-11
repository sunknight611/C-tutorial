using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
     class Duck:Bird,ISwim,IFood
    {
        public void cook()
        {
            Console.WriteLine("COOK");
        }

        public override void fly()
        {
            Console.WriteLine("Fly");
        }
        
        public void swim()
        {
            Console.WriteLine("swim");
        }

        public readonly string type = IFood.laserPrinter;
        public void print(string info)
        {
            Console.WriteLine($"使用{type}打印：{info}");
        }
    }
}
