namespace ExceptionCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InputNumber();
            //try
            //{
            //int[] values = new int[10];
            //for(int i = 0;i <= 10; i++)
            //{
            //    Console.WriteLine(values[i]);
            //}
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.GetType().Name);
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}

            try
            {
                throwExceptionMethod();
            }
            catch(myException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void InputNumber()
        {
            Console.WriteLine("请输入一个正整数");
            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if(value <= 0)
                {
                    throw new InvalidOperationException("你输入的不是正整数");
                }
                Console.WriteLine("您输入的数字是:{0}", value);
            }
            catch(FormatException){
                Console.WriteLine("您输入的字符串无法转化成数字");
            }
            catch (OverflowException)
            {
                Console.WriteLine("你输入的数字太大了");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("敲任意键退出。。。");
            }
        }

        public static void throwExceptionMethod()
        {
            try
            {
                Console.WriteLine("throwException");
                Console.WriteLine("throwException抛出一个异常");

                throw new Exception("系统运行时引发的异常");
            }

            catch(Exception e)
            {
                Console.WriteLine("系统运行时引发的Exception异常");
                throw new myException("throw my Exception");
            }
            finally
            {
                Console.WriteLine("finnaly执行结束");
            }
        }
    }

    public class myException : Exception
    {
        public myException(string message) : base(message)
        {

        }

        public myException(string e,Exception innerException) : base(e, innerException)
        {

        }
    }
}