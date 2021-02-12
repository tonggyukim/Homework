using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number to calculate it's factorial!:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0) break;
                Console.WriteLine("{0}! = {1}", n, fact(n));
            }
        }

        public static int fact(int n)
        {
            if (n<1) { return 1; }

            return checked(n * fact(n - 1));



            }
    }
}
