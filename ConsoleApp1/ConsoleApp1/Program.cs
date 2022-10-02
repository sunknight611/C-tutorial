// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        MyClass obj1 = new MyClass
        {
            IntValue = 100,
            setValue = "hello"
        };
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
    public class MytestClass2
    {
        public string MyProp
        {
            get;
            set;
        }
    }
    public class MyClass
    {
        public int IntValue;
        public string setValue
        {
            get;
            set;
        }
    }
}