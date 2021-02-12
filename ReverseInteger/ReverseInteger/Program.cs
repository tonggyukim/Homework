using System;

namespace ReverseInteger
{
    class Program
    {
        public int Reverse(int input)
        {
            int result = 0;
            //if (input < 0)
            //{
                
            //}
            while (input !=0)
            {
                result = result * 10 + input % 10;
                input = input / 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give a 32 bit signed integer: ");
            string input = Console.ReadLine();
            int convertedInput = int.Parse(input);
            Program tool = new Program();
            int answer = tool.Reverse(convertedInput);
            Console.WriteLine($"{answer}");


        }
    }
}
