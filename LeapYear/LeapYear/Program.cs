using System;

namespace Hello_world2
{
    class Utility
    {
        public bool isLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            else if (year % 100 == 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Utility util = new Utility();
            while (true)
            {
                Console.Write("Enter Year:");
                string input = Console.ReadLine();
                if (util.isLeapYear(int.Parse(input)))
                {
                    Console.WriteLine("{0} is Leap Year", input);
                }
                else
                {
                    Console.WriteLine("{0} is not Leap Year,", input);
                }
            }

        }
    }
}
