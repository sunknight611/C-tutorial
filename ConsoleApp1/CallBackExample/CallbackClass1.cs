using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    internal class CallbackClass1:ICallback
    {
        public int counter { get; set; }
        public void run()
        {
            counter++;
            Console.WriteLine("i'm invoked" + counter.ToString() + "times");
        }
    }
}
