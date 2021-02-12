using System;
using System.Text;

namespace findKthBitInNthBinaryString
{
    class Solution
    {
        public char FindKthBit(int n, int k)
        {
            //string[] s = new string[n+1];
            //s[1] = "0";

            //for (int i = 2; i <= n; i++)
            //{
            //    s[i] = s[i - 1] + "1" + ReverseString(invert(s[i - 1]));
            //}
            string s = findS(n);
            Console.WriteLine($"{s}");
            return s[k-1];
        }

        public string invert(string s)
        {
            string invertString = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                invertString += (s[i] == '0') ? '1' : '0';
                //if (s[i] == '0')
                //{
                //    invertString += '1';
                //}
                //else
                //{
                //    invertString += '0';
                //}
            }

            return invertString;
        }

        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        //    void Reverse(char[] array)
        //    {
        //        for(int i = array.Length - 1; i>=0; --i)
        //        {
        //            a(char[i]);
        //        }
        //    }
        public string findS(int n)
        {
            Console.WriteLine($"{n}");
            if (n == 1)
            {
                return "0";
            }
            return findS(n - 1) + "1" + ReverseString(invert(findS(n - 1)));
        }
    }



    class Program
    {
            static void Main(string[] args)
        {
            Console.Write("What is n?: ");
            string n = Console.ReadLine();
            int intN = int.Parse(n);
            Console.Write("What is k?: ");
            string k = Console.ReadLine();
            int intK = int.Parse(k);

            Solution tool = new Solution();
            char answer = tool.FindKthBit(intN, intK);
            Console.WriteLine($"Kth Bit is {answer}");




        }
    }
}
