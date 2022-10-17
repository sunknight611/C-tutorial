namespace CallBackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.AddCallBack(new CallbackClass());
            controller.AddCallBack(new CallbackClass1());
            controller.Begin();
        }
    }
}