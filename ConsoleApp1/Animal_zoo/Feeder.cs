using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_zoo
{
     class Feeder
    {
        public String Name
        {
            get; set; 
        }

        public void feed(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                animal.eat(Name);
            }
        }
    }
}
