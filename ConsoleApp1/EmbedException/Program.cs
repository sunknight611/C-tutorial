using System.Security.Cryptography;

namespace EmbedException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("进入lvl1的try块");
                try
                {
                    Console.WriteLine("进入lvl2的try块");
                    try
                    {
                        Console.WriteLine("进入lvl3的try语句块");

                        //throw new ExceptionC();
                        //throw new InvalidProgramException();

                        Console.WriteLine("退出lvl3的try语句块");
                    }
                    catch(ExceptionA e)
                    {
                        Console.WriteLine("捕获异常A");
                    }
                    finally
                    {
                        Console.WriteLine("lvl3的finally块");
                        WriteMessageInfo("lvl3.txt", "lvl3的fianlly块");
                    }
                    Console.WriteLine("退出lvl2的try语句块");
                }
                catch(ExceptionB e)
                {
                    Console.WriteLine("捕获异常B");
                }
                finally
                {
                    Console.WriteLine("lvl2的finally块");
                }
                Console.WriteLine("退出lvl1的try块");
            }
            catch(ExceptionC e)
            {
                Console.WriteLine("捕获异常C");
            }
            //catch (Exception)
            //{

            //}
            finally
            {
                Console.WriteLine("lvl1的finally块");
            }
        }

        private static void WriteMessageInfo(string filename,string message)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter sw =new StreamWriter(fs);

            sw.Write(message);
            sw.Close();
            fs.Close();
        }
    }

    class ExceptionA : Exception
    {

    }

    class ExceptionB : Exception
    {

    }

    class ExceptionC : Exception
    {

    }

}