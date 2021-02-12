using System;

namespace PostFixPreFix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, j;
            a = 5;
            i = (++a) + (++a);
            Console.WriteLine("i={0}, a={1}", i, a);
            j = (--a) + (++a);
            Console.WriteLine("i ={0}, j ={1}, a ={2}",i,j,a);
        }
    }
}
