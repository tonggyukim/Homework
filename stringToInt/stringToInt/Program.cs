using System;

namespace stringToInteger
{
    class Program
    {
        public int stringToInteger (string input)
        {
            //int index = 0, sign = 1, total = 0;
            //// remove white spaces
            //while (index < input.Length && input[index] == ' ') index++;
            //// get sign
            //sign = index < input.Length && (input[index] == '+' || input[index] == '-') ? input[index++] == '+' ? 1 : -1 : 1;
            //// calculate and take care of overflow
            //while (index < input.Length)
            //{
            //    int digit = 
            //}
            int value = 0;
            int sign = 1;
            input = input.Trim();
            int i = 0; 
            if (input[0] == '+')
            {
                i++;
            }

            else if (input[0] == '-')
            {
                sign = -1;
                i++;
            }

            for (; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                value = value * 10 + digit;
                if (value > int.MaxValue)
                {
                    return int.MaxValue * sign;
                }
            }
            return value * sign;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string: ");
            string input = Console.ReadLine();
            Program tool = new Program();
            int answer = tool.stringToInteger(input);
            Console.WriteLine($"{answer}");
        }
    }
}
