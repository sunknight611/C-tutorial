namespace PatternMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "test";
            //typeMatch(s);
            //Console.WriteLine(getStringLength(s));
            Console.WriteLine(s is String {Length:5}str);

        }

        static void typeMatch(object input)
        {
            if(input is string str)
            {
                Console.WriteLine(str);
            }

            if(input is int longValue)
            {
                Console.WriteLine(longValue);
            }
        }

        static int getStringLength(string str)
        {
            var result = str switch
            {
                null => -1,
                "" => 0,
                _ => str.Length
            };
            return result;
        }
    }

    
}