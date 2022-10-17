using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    internal class CallbackClass:ICallback
    {
        public void run()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
