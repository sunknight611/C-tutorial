using System.Runtime.CompilerServices;

namespace OnetoMoreObjectEmbed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            One2ManyTest();
        }

        private static void One2ManyTest()
        {
            OnetoMoreClass onetoMoreClass = new OnetoMoreClass();

            for(int i = 0;i < 5; i++)
            {
                onetoMoreClass.Add(new InnerClass());
            }

            onetoMoreClass.Remove(0);


            List<InnerClass> InnerList = new List<InnerClass>();
            for(int i = 0;i < 5; i++)
            {
                InnerList.Add(new InnerClass());
            }

            OnetoMoreClass2<InnerClass> onetoMoreClass2 = new OnetoMoreClass2<InnerClass>(InnerList);
        }
    }

    //内部定义一些公有方法实现向其内部集合中增删对象
    class OnetoMoreClass
    {
        private List<InnerClass> objs = new List<InnerClass>();

        public void Add(InnerClass obj)
        {
            if(obj != null)
            {
                objs.Add(obj);
            }
        }

        public void Remove(int index)
        {
            if(index >=0 && index < objs.Count)
            {
                objs.RemoveAt(index);
            }
        }
    }

    class OnetoMoreClass2<T>
    {
        private IEnumerable<T> objs = null;

        public OnetoMoreClass2(IEnumerable<T> objCollections)
        {
           objs = objCollections;
        }
    }
    class InnerClass
    {
        public InnerClass()
        {

        }
    }
}