// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using MyClassLibrary;
namespace ConsoleApp1
{
      internal class Program
     {
        private static void Main(string[] args)
       {
            //Console.WriteLine("Hello, World!");
            ////String input = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Red;
            ////Console.WriteLine(input);
            //DateTime date = DateTime.Now;
            //Console.WriteLine($"当前日期为{date.Year}年{date.Month}月{date.Day}日");
            //Console.Beep();
            //int vlaue = 100;
            //do
            //{
            //    var key = Console.ReadKey(true);
            //    if(key.Key == ConsoleKey.Escape)
            //    {
            //        Console.WriteLine("\n检测到ESC键，敲任意键退出");
            //        break;
            //    }
            //    if(key.KeyChar != '\0')
            //    {
            //        if(key.Key == ConsoleKey.Enter)
            //        {
            //             Console.WriteLine();
            //        }
            //        else
            //        {
            //             Console.Write(key.KeyChar);
            //        }
            //    }

            //}while(true);
            //PrintIntarray(1, 2, 3);
            //PrintIntarray(2, 3);

            // MyClass obj1 = new MyClass
            //{
            //     IntValue = 100,
            //     setValue = "hello"
            //};
            // obj1.show();  
            //MathLibrary lib = new MathLibrary();
            //Console.WriteLine(lib.Add(100, 200));
            //Console.ReadKey();
            int i = 100;
            int j = 100;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
            MyClass obj1 = new MyClass();
            MyClass obj2 = new MyClass();
            Console.WriteLine(obj1.Equals(obj2));

        }

        static void PrintIntarray(params int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
           {
               Console.Write(numbers[i]);
               if (i != numbers.Length - 1)
                  Console.Write(",");
           } 
            Console.WriteLine();
        }
     } 
    public class MytestClass2
    {
        public string MyProp
        {
            get;
            set;
        }
    }
     public partial class MyClass
    {
        public int IntValue;
        public int value = 100;
        public string setValue
        {
            get;
            set;
        }
        partial void Test();
        public void show() 
        {
            Test();
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }else if(obj is MyClass)
            {
                return this.value == (obj as MyClass).value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return value;
        }
    }

    partial class MyClass
    {
        partial void Test()
        {
            int value = 100;
            static void dosomething()
            {
                int value = 200;
                value++;
                Console.WriteLine($"inner value = {value}");
            }
            dosomething();
            Console.WriteLine($"inner value = {value}"); 
        }
    }
}
  