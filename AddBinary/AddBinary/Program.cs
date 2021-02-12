using System;

namespace AddBinary
{
    class Program
    {
        public string addBinary(string input1, string input2)
        {
            int convertedInput1 = Convert.ToInt32(input1.Trim(), 2);
            int convertedInput2 = Convert.ToInt32(input2.Trim(), 2);
            string answer = Convert.ToString(convertedInput1 + convertedInput2, 2);
            return answer;
        }
        static void Main(string[] args)
        {
            //Console.Write("Give one binary number: ");
            //string input1 = Console.ReadLine();
            //Console.Write("Give another binary number: ");
            //string input2 = Console.ReadLine();
            Console.Write("Add two binary expressions: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split('+', ' ', StringSplitOptions.RemoveEmptyEntries);

            Program solution = new Program();
            //string answer = solution.addBinary(input1, input2);
            string answer = solution.addBinary(inputArray[0], inputArray[1]);
            Console.WriteLine($"The sum of these two numbers is {answer}");
        }
    }
}
