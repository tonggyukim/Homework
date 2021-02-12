using System;

namespace binary
{
    class Tool
    {
        public int binToInt(string input)
        {
            int number = 0;
            for (int i=0; i < input.Length; i++)
            {
                if (input[i] == '0')
                {
                    number = number * 2;
                }
                else
                {
                    number = number * 2 + 1;
                }
            }
            return number;
        }

        public string IntToBin(int input)
        {
            string binary = "";
            while (input>0)
            {
                binary = ToString(input % 2) + binary;
                input = (int)input/2;
            }
            return binary;
        }

        private string ToString(int input)
        {
            //if (input == 1)
            //{
            //    return "1";
            //}
            //else
            //{
            //    return "0";
            //}
            return input == 1 ? "1" : "0";
        }

        public int NumSteps(int value)
        {
            int steps = 0;
            while (value>1)
            {
                if (value%2==0)
                {
                    value = value / 2;
                }
                else
                {
                    value = value + 1;
                }
                steps++;
            }
            return steps;
        }

        public int StrToInt (string str)
        {
            int num = 0;
            for (int i=0; i<str.Length; i++)
            {
                num = (num * 10) + str[i] - '0';
            }


            return num;
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number as a string: ");
            string input = Console.ReadLine();
            Tool tool = new Tool();
            int value = tool.StrToInt(input);
            //string binaryNotation = tool.IntToBin(int.Parse(input));
            //int steps = tool.numSteps(value);
            //Console.WriteLine("Binary Notation of {0} is 0b{1}", input, binaryNotation);
            Console.WriteLine("Int value of {0} is {1}", input, value);
        }
    }
}
