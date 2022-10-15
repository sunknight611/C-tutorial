using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace EventKeyWord
{
    public delegate void MyEventDelegate(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Publisher publisher = new Publisher();
            //Subscriber s1 = new Subscriber();
            //Subscriber s2 = new Subscriber();

            //publisher.MyEvent += s1.MyMethod;
            //publisher.MyEvent += s2.MyMethod;

            //publisher.MyEvent(new Random().Next(1, 100));

            Publisher publisher = new Publisher();

            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();

            //publisher.MyEvent += s1.MyMethod;
            //publisher.MyEvent += s2.MyMethod;
            string? input = null;

            while(true)
            {
                input = Console.ReadLine();
                if (input == "a")
                {
                    publisher.MyEvent += new Subscriber().MyMethod;
                    publisher.FireEvent(new Random().Next(1, 100));
                }               
                else break;
            }

            
        }
    }

    //public class Publisher
    //{
    //    public MyEventDelegate MyEvent;  
    //}

    public class Subscriber
    {
        public void MyMethod(int value)
        {
            Console.WriteLine(value);
        }
    }
    public class Publisher
    {
        public event MyEventDelegate MyEvent;
        public void FireEvent(int EventArgu)
        {
            if(MyEvent != null)
            {
                MyEvent(EventArgu);
            }
        }
    }
}