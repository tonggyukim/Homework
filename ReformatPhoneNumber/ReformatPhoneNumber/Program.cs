using System;

namespace ReformatPhoneNumber
{
    class Program
    {
        public string Reformater(string phoneNumber)
        {
            char[] spacesDashes = { ' ', '-' };
            string newPhoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");
            phoneNumber.Substring(50);
            string formattedNumber = "";
            while (newPhoneNumber.Length > 4)
            {
                formattedNumber += newPhoneNumber.Substring(0, 3) + "-";
                newPhoneNumber = newPhoneNumber.Substring(3);
            }
            if (newPhoneNumber.Length == 4)
            {
                formattedNumber += newPhoneNumber.Substring(0, 2) + '-' + newPhoneNumber.Substring(2, 2);
            }
            else
            {
                formattedNumber += newPhoneNumber;
            }
            return formattedNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Give a phone number: ");
            string number = Console.ReadLine();
            Program solution = new Program();
            string formattedNumber = solution.Reformater(number);
            Console.WriteLine($"{formattedNumber}");
        }
    }
}
