using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjectCloneViaSerialization
{
    [Serializable]
    class MyClass
    {
        public int Index = 1;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj= new MyClass();
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formator = new BinaryFormatter();
                formator.Serialize(ms, obj);
                for(int i = 0; i < 100; i++)
                {   //回到流的开头
                    ms.Seek(0,SeekOrigin.Begin);
                    //反序列化对象 
                    obj = (formator.Deserialize(ms) as MyClass);
                    obj.Index += i;
                    Console.WriteLine(obj.Index);
                }
            }
        }
    }
}