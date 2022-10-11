using System.Net.Http.Headers;
using System.Text;

namespace NullType
{
//#nullable enable
    internal class Program
    {
        static void Main(string[] args)
        {
            //var nullableInt = new Nullable<int>();
            //Console.WriteLine(nullableInt.HasValue);

            //int? x = null;
            //var res = x + 100;
            //Console.WriteLine(res == null);
            //string? notnullableString = null;
            //int l = MyClass.getLength(notnullableString);
            //int? a = null;
            //a ??= 8;
            //Console.WriteLine(a);

            //StringBuilder sb = null;
            ////StringBuilder sb = new StringBuilder("dadada");
            //string s = sb?.ToString();
            //Console.WriteLine(s==null);

            //void Foo(string? s) => Console.Write(s!.Length);

            //StringBuilder sb = null;
            //string s = sb?.ToString() ?? "nothing";
            //Console.WriteLine(s);

            string test = null;
            MyClass.handle(test);

        }

    
        
       
    }


    class MyClass
    {
        public string? extraInfo { get; set; }
        public string Info { get; set; } = "";
        public byte? SomeValue { get; set; } = null;
        public static int getLength(string? input)
        {
            return input.Length;
        }

        public static void handle(string? value)
        {
            if(value == null)
            {
                throw new NullReferenceException();
            }
            else
            {

            }
        }

    }
}