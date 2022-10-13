using System.Data;
using System.Security.Cryptography;
using System;
namespace Delegate
{  public class MathOpt
   {
            public int Add(int x,int y)
            {
                return x + y;
            }

            public static int Max(int x,int y)
            {
                return x > y ? x : y; 
            }

    }

    public class TaskInfo
    {
        public int count = 0;
    }
    
    public delegate int MathOptDelegate(int value1, int value2);
    internal class Program
    {
      
        static int UseDelegate(MathOptDelegate option,int x,int y)
        {
            return option(x,y);
        }
        
        static void Main(string[] args)
        {
            //MathOptDelegate obj;
            //MathOpt math = new MathOpt();
            //obj = math.Add;
            //obj = MathOpt.Max;
            //Console.WriteLine(obj(1,2));
            //Console.WriteLine(UseDelegate(MathOpt.Max, 2, 3));
            TaskInfo ti = new TaskInfo();
            Timer timer = new Timer(ShowTime, ti, 0, 1000);
            Console.ReadKey();
            timer.Dispose();
        }

        static void ShowTime(Object ti)
        {
            TaskInfo obj = ti as TaskInfo;
            obj.count++;
            System.Console.WriteLine("({0}){1}",obj.count,DateTime.Now);
        }
    }
}