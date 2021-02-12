using System;

namespace WaterBottles
{
    class Program
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int answer = numBottles;
            //drink
            int empty = numBottles;
            //do i have enough bottles to exchange?
            while (empty >= numExchange)
            {
                //exchange
                int newFull = (int)(empty / numExchange);
                //drink
                answer += newFull;
                //adding remaining empty bottles
                empty = newFull + empty % numExchange;
            }

            return answer;
        }
        static void Main(string[] args)
        {
            Console.Write("How many water bottles do you have?: ");
            string rawNumWB = Console.ReadLine();
            int numWB = int.Parse(rawNumWB);
            Console.Write("How many empty bottles can you exchange for one?: ");
            string rawExchange = Console.ReadLine();
            int numExchange = int.Parse(rawExchange);

            Program tool = new Program();
            int answer = tool.NumWaterBottles(numWB, numExchange);
            Console.WriteLine($"You have {answer} bottles");
        }
    }
}
