using System.Net;
using System.Runtime.CompilerServices;

namespace GenericProgram
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            //string minStr = "a", maxStr= "b";
            //int a = 0, b = 0;
            ////Console.WriteLine("Hello, World!");
            //string[] str_test = new string[] { "dadada", "dadawewe" };
            //int[] num_test = new int[] { 1, 2, 3, 4, 5 };

            //Generic g = new Generic();
            //g.GetMinValueFromArray<string>(str_test, ref minStr,ref maxStr);
            //g.GetMinValueFromArray<int>(num_test, ref a, ref b);

            //float[] arr = new float[] { 2.0f, 7.1f, 7.3f, 6.0f, 4.0f, 1.0f };
            //GenericList<string>.Sort<float>(arr);
            //foreach (float i in arr)
            //{
            //    Console.WriteLine("{0,-3:F1}",i);
            //}

            string[] arr = new string[] { "befadae", "beeefd","dawaeaea" };
            GenericList<string>.Sort(arr);
            foreach(var str in arr)
            {
                Console.WriteLine(str);
            }
        }      
    }
    
    public class Generic
    {
           public void GetMinValueFromArray<T>(T[] datas,ref T min,ref T max)where T : IComparable
           {
               max = datas[0];
               min = datas[1];
               Console.WriteLine(max);
               Console.WriteLine(min);
           }
    }

    public class GenericList<T>:IComparable<T>
    {
       public static void Sort<T>(T[] arr)where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
                for(int j = i;j < arr.Length; j++)
                {
                    T arg1 = arr[i];
                    T arg2 = arr[j];
                    if (arg1.CompareTo(arg2) < 0)
                    {
                        T temp;
                        temp = arg2;
                        arg2 = arg1;
                        arg1 = temp;

                        arr[i] = arg1;
                        arr[j] = arg2;
                    }
                }
       }

        public int CompareTo(T? other)
        {
            if(other is string)
            {
                return string.Compare(this.ToString(),other.ToString());
            }
            else return CompareTo(other);
        }
    }

}