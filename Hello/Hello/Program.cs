using System;

namespace Hello
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i=1;i<=10;i++)
            {
                sum = sum + i;
            };

             Console.WriteLine("sum 1 to 10 = {0}",sum)
                ;
        }
    }
}
