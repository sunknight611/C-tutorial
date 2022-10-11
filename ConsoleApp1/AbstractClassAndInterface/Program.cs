using System.Runtime.InteropServices;

namespace AbstractClassAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird duck = new Duck();
            IFood food = new Duck();
            duck.fly();
            food.cook();
            food.print("你好");
            food.printDefault();
        }
    }
}