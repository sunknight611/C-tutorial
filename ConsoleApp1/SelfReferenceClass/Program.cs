namespace SelfReferenceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class MyClass
    {
        MyClass obj;
    }
}