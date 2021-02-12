using System;

namespace BubbleSort
{
    public class Solution
    {
        public void sort(int[] array)
        {
            bool flag = true;
            while (flag==true)
            {
                flag = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i]>array[i+1])
                    {
                        swap(array, i, i+1);
                        flag = true;
                    }
                }
            }
            //for (int i = 0; i<array.Length; i++)
            //{
            //    bool flag = true;
            //    while (flag == true)
            //    {
            //        for (int j=0; j<array.Length-1;j++)
            //        {
            //            if (array[j]>array[j+1])
            //        }
            //    }
            //}
        }
        public void swap (int[] array,int i,int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            string input = Console.ReadLine();
            char[] seperator = { ',', ' ' };
            string[] strList = input.Split(seperator);
            int[] intList = new int[strList.Length];

            for (int i = 0; i < strList.Length; i++)
            {
                intList[i] = int.Parse(strList[i]);
            }

            Solution sol = new Solution();
            sol.sort(intList);
            for (int i = 0; i < intList.Length; i++)
            {
                Console.Write($"{intList[i]},");
            }
        }

    }
}
