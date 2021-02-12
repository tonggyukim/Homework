using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Solution
    {
        public int romToInt(string rom)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            rom = rom.ToUpper();
            int num = 0;
            if (rom.Contains("IV"))
            {
                rom = rom.Replace("IV", "");
                num += 4;
            }

            if (rom.Contains("IX"))
            {
                rom = rom.Replace("IX", "");
                num += 9;
            }

            if (rom.Contains("XL"))
            {
                rom = rom.Replace("XL", "");
                num += 40;
            }
            if (rom.Contains("XC"))
            {
                rom = rom.Replace("XC", "");
                num += 90;
            }

            if (rom.Contains("CD"))
            {
                rom = rom.Replace("CD", "");
                num += 400;
            }

            if (rom.Contains("CM"))
            {
                rom = rom.Replace("CM", "");
                num += 900;
            }

            foreach(char c in rom)
            {
                //switch (Char.ToUpper(c))
                //{
                //    //case 'i': 
                //    case 'I': num += 1;
                //        break;
                //    case 'V':
                //        num += 5;
                //        break;
                //    case 'X':
                //        num += 10;
                //        break;
                //    case 'L':
                //        num += 50;
                //        break;
                //    case 'C':
                //        num += 100;
                //        break;
                //    case 'D':
                //        num += 500;
                //        break;
                //    case 'M':
                //        num += 1000;
                //        break;
                //    default: Console.WriteLine($"invalid symbol: {c}");
                //        break;

                //}
                if (dict.ContainsKey(c))
                {
                    num += dict[c];
                }
                else
                {
                    Console.WriteLine($"invalid symbol: {c}");
                }
            }

            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a roman numeral: ");
            string romanNumeral = Console.ReadLine();
            Solution solution = new Solution();
            int answer = solution.romToInt(romanNumeral);
            Console.WriteLine($"{answer}");
        }
    }
}
