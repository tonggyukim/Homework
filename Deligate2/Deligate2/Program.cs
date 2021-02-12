using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ComposableDelegates2

{

    // using reference parameters enables results to be passed 

    // along from one delegate to the next



    class Program

    {

        public delegate double shippingRateCalculator(int price, double rate);





        static void Main(string[] args)

        {

            shippingRateCalculator normalShipping = delegate (int price, double rate)

            {

                return price * rate;

            };



            shippingRateCalculator riskyShipping = delegate (int price, double rate)

            {

                return price * rate + 25;

            };



            Dictionary<string, Tuple<double, shippingRateCalculator>> zoneToDelegate = new Dictionary<string, Tuple<double, shippingRateCalculator>>()

{

{"zone1" , new Tuple<double, shippingRateCalculator>(0.25, normalShipping) },

{"zone2" , new Tuple<double, shippingRateCalculator>(0.12, riskyShipping) },

{"zone3" , new Tuple<double, shippingRateCalculator>(0.08, normalShipping) },

{"zone4" , new Tuple<double, shippingRateCalculator>(0.04, riskyShipping) }

};



            while (true)

            {

                Console.WriteLine("What is the destinateion zone? ");

                String zone = Console.ReadLine();

                if (zone.ToUpper().Equals("EXIT"))

                {

                    break;

                }

                Console.WriteLine("What is the itme price?");

                int price = int.Parse(Console.ReadLine());

                Tuple<Double, shippingRateCalculator> tuple = zoneToDelegate[zone.Trim()];

                Console.WriteLine($"The shipping fees are : {tuple.Item2(price, tuple.Item1)}");

            }



            Console.WriteLine("\nPress Enter Key to Continue...");

            Console.ReadLine();

        }

    }

}
