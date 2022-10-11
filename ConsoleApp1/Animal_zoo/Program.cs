using System.IO.Pipes;

namespace Animal_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal> { new Lion(), new Monkey() };

            Feeder feeder = new Feeder { Name = "xiaowu" };

            feeder.feed(animals);   
        }
    }
}