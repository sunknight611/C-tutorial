using System.Runtime.Remoting;
using System.Transactions;

namespace ObjectClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ObjectCopyViaFieldCopy();
            //ClassB classB = new ClassB();
            //ClassB cloned = ClassB.CloneObject(classB);

            //Console.WriteLine(classB == cloned);
            //Console.WriteLine(classB.value == cloned.value);
            //Console.WriteLine(classB.objA == cloned.objA);
            //Console.WriteLine(classB.objA.value == cloned.objA.value);
            ClassA objA = new ClassA();
            objA.AValue = 100;
            objA.objB = new ClassB();

            ClassA others = (objA as ICloneable).Clone() as ClassA;
            Console.WriteLine(objA == others);
            Console.WriteLine(objA.objB == others.objB);

        }

        static void ObjectCopyViaFieldCopy()
        {
            MyClass obj = new MyClass {MyClassValue = 120};
            MyClass other = MyClass.CloneObject(obj);
            Console.WriteLine(other.ToString());
            Console.WriteLine(other.Equals(obj));
            Console.WriteLine(obj == other);
        }
    }

    class MyClass
    {
        public int MyClassValue { get; set; } = 100;
        public override string ToString()
        {
            return "MyClassValue:" + MyClassValue;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || obj is MyClass == false)
            {
                return false;
            }

            return MyClassValue == (obj as MyClass).MyClassValue;
        }

        public override int GetHashCode()
        {
            return MyClassValue;
        }

        public static MyClass CloneObject(MyClass obj)
        {
            MyClass cloned = new MyClass();
            cloned.MyClassValue = obj.MyClassValue;
            return cloned;
        }
    }

    class ClassA:ICloneable
    {
        //public int value = 100;
        //public ClassA()
        //{

        //}
        public int AValue = 100;
        public ClassB objB;
        public Object Clone()
        {
            ClassA cloned = new ClassA();
            cloned.AValue = this.AValue;
            cloned.objB = (this.objB as ICloneable).Clone() as ClassB;
            return cloned;
        }
    }

    class ClassB:ICloneable
    {
        //public ClassA objA;
        //public int value = 100;
        //public ClassB()
        //{
        //    objA = new ClassA();
        //}

        //public static ClassB CloneObject(ClassB obj)
        //{
        //    ClassB cloned = new ClassB();
        //    cloned.value = obj.value;
        //    cloned.objA = obj.objA;

        //    return cloned;
       
        public int BValue = 200;
        public Object Clone()
        {
            ClassB objB = new ClassB();
            objB.BValue = this.BValue;
            return objB;
        }
    }
}