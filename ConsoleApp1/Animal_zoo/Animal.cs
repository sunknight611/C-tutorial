using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_zoo
{
     class Animal
    {
        public virtual void eat(String feeder)
        {

        }
    }

    class Lion : Animal
    {
        public override void eat(String feeder)
        {
            Console.WriteLine($"{feeder} lion eat");
        }
    }

    class Monkey : Animal
    {
        public override void eat(String feeder)
        {
            Console.WriteLine($"{feeder} monkey eat");
        }
    }
}
