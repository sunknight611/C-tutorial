namespace ObjectEmbed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InnerClass innerLClass = new InnerClass();
            OutClass2 outClass2 = new OutClass2(innerLClass);

        }
    }
 //对象包含组合方式
    class InnerClass
    {

    }

    class OuterClass
    {
        private InnerClass obj = null;
        public OuterClass()
        {
            obj = new InnerClass();

        }
    }

  //对象协作组合方式
  class OutClass2
    {
        private InnerClass obj = null;
        public OutClass2(InnerClass outerObj)
        {
            obj = outerObj;
        }
    }
}