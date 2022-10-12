using System.Xml.Serialization;

namespace ObjectSerilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Serializer = new XmlSerializer(typeof(MyClass));

            MyClass obj = new MyClass()
            {
                IntField = 100,
                StringField = "Hello"
            };

            Serializer.Serialize(Console.Out, obj);
            Console.ReadKey();
        }
    }

    public class MyClass
    {
        public int IntField;
        public string StringField;
       
    }


}