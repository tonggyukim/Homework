using System;
using System.Collections.Generic;
using System.Linq;

namespace SortList
{
    class Program
    {
        public void SortTuple (List <(string Firstname, string Age)> tupleList)
        {
            //var result = tupleList.OrderBy(x => x.Item2).ToList();
            tupleList.Sort((a, b) => a.Firstname.CompareTo(b.Firstname));
        }

        public void DumpTupleList(List<(string Firstname, string Age)> tupleList)
        {
            foreach(var tuple in tupleList)
            {
                Console.WriteLine($"{tuple.Firstname},{tuple.Age}");
            }
        }

        static void Main(string[] args)
        {
            List<(string Firstname, string Age)> tupleList = new List<(string Firstname, string Age)>
            {
            ( "David", "22" ),
            ( "Kevin", "24" ),
            ( "Dad", "54" ),
            ( "Mom", "50" )
            };
            Program sorter = new Program();
            Console.WriteLine("Before Sorting");
            sorter.DumpTupleList(tupleList);
            sorter.SortTuple(tupleList);
            Console.WriteLine("After Sorting");
            sorter.DumpTupleList(tupleList);
        }
    }
}
