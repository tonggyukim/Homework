using System;

namespace Delegate
{
    public delegate decimal ShippingFeeDelegate(decimal price);


    class Program
    {   static decimal zone1(decimal price)
        {
            return (decimal)((double)price * 0.25);
        }
        static decimal zone2(decimal price)
        {
            return (decimal)((double)price * 0.12 + 25);
        }
        static decimal zone3(decimal price)
        {
            return (decimal)((double)price * 0.08);
        }
        static decimal zone4(decimal price)
        {
            return (decimal)((double)price * 0.04 + 25);
        }
        static void Main(string[] args)
        {
            short val = 32767;
            Console.WriteLine($"current value is {val}");
            val++;
            Console.WriteLine($"Increment 1 is {val}");
              
            //while (true)
            //{
            //    Console.Write("What is the destination zone?: ");
            //    string destination = Console.ReadLine();
            //    //if (destination.Equals("exit",StringComparison.InvariantCultureIgnoreCase))
            //    if (destination.ToLower() =="exit")
            //    {
            //        break;
            //    }
            //    Console.Write("What is the item price?: ");
            //    string rawItemPrice = Console.ReadLine();
            //    decimal convertedItemPrice = decimal.Parse(rawItemPrice);
            //    ShippingFeeDelegate f;
            //    if (destination.Equals("zone1"))
            //    {
            //        f = zone1;
            //        Console.WriteLine("The shipping fee is " + f(convertedItemPrice));
            //    }
            //    else if (destination.Equals("zone2"))
            //    {
            //        f = zone2;
            //        Console.WriteLine("The shipping fee is " + f(convertedItemPrice));
            //    }
            //    else if (destination.Equals("zone3"))
            //    {
            //        f = zone3;
            //        Console.WriteLine("The shipping fee is " + f(convertedItemPrice));
            //    }
            //    else if (destination.Equals("zone4"))
            //    {
            //        f = zone4;
            //        Console.WriteLine("The shipping fee is " + f(convertedItemPrice));
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Unknown Zone: {destination}");
            //Console.WriteLine("Unknown Zone: {0}" ,destination);
        }
            }
        }
//    }
//}
  