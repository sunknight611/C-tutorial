//class Program7
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Client application started!\n");
//        Thread.CurrentThread.Name = "Main Thread";
//        Calculator cal = new Calculator();
//        int result = cal.Add(2, 5);
//        Console.WriteLine("Result: {0}\n", result);

//        // 做某些其它的事情，模拟需要执行3 秒钟
//        for (int i = 1; i <= 3; i++)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(i));
//            Console.WriteLine("{0}: Client executed {1} second(s).", Thread.CurrentThread.Name, i);
//        }

//        Console.WriteLine("\nPress any key to exit...");
//        Console.ReadLine();
//    }
//}

//public class Calculator
//{
//    public int Add(int x, int y)
//    {
//        if (Thread.CurrentThread.IsThreadPoolThread)
//        {
//            Thread.CurrentThread.Name = "Pool Thread";
//        }
//        Console.WriteLine("Method invoked!");

//        // 执行某些事情，模拟需要执行2 秒钟
//        for (int i = 1; i <= 2; i++)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(i));
//            Console.WriteLine("{0}: Add executed {1} second(s).", Thread.CurrentThread.Name, i);
//        }

//        Console.WriteLine("Method complete!");
//        return x + y;
//    }
//}

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public delegate int AddDelegate(int x, int y);

class Program8
{
    static void Main(string[] args)
    {
        Console.WriteLine("Client application started!\n");
        Thread.CurrentThread.Name = "Main Thread";
       
        Calculator cal = new Calculator(); 
        AddDelegate caller = new AddDelegate(cal.Add);
        //AddDelegate del = new AddDelegate(cal.Add);
        //IAsyncResult asyncResult = del.BeginInvoke(2, 5, null, null); // 异步调用方法
        var workTask = Task.Run(()=>
            caller.Invoke(2, 5));
        // 做某些其它的事情，模拟需要执行3 秒钟
        for (int i = 1; i <= 3; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(i));
            Console.WriteLine("{0}: Client executed {1} second(s).", Thread.CurrentThread.Name, i);
        }

        int rtn = workTask.Result;
        Console.WriteLine("Result: {0}\n", rtn);
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}

public class Calculator
{
    public int Add(int x, int y)
    {
        if (Thread.CurrentThread.IsThreadPoolThread)
        {
            Thread.CurrentThread.Name = "Pool Thread";
        }
        Console.WriteLine("Method invoked!");

        // 执行某些事情，模拟需要执行2 秒钟
        for (int i = 1; i <= 2; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(i));
            Console.WriteLine("{0}: Add executed {1} second(s).", Thread.CurrentThread.Name, i);
        }
        Console.WriteLine("Method complete!");
        return x + y;
    }
}