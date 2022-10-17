using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    internal class Controller
    {
        private List<ICallback> _callbacks = new List<ICallback>();
        public void AddCallBack(ICallback callback)
        {
            _callbacks.Add(callback);
        }

        public void Begin()
        {
            Console.WriteLine("敲任意键回调方法，ESC键退出");

            while(Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine();
                foreach (ICallback obj in _callbacks)
                    obj.run();
            }
        }
    }
}
