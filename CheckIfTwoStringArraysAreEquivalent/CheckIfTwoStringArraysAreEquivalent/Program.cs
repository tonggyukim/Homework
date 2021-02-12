using System;
using System.Text;

namespace CheckIfTwoStringArraysAreEquivalent
	{
		class Program
			{
				private bool StringChecker (string [] strArray1, string[] strArray2)	
					{	
						if (String.Join("", strArray1) == string.Join("", strArray2))
						{
							return true;
						}
						return false;
					}
		static void Main(string[] args)
			{
				Console.WriteLine("Give an array of strings: ");
				string input1 = Console.ReadLine();
				string[] strArray1 = input1.Split(',', ' ');
				Console.WriteLine("Give another array of strings: ");
				string input2 = Console.ReadLine();
				string[] strArray2 = input2.Split(' ', ',');
				Program solution = new Program();
				bool Answer = solution.StringChecker(strArray1, strArray2);	
				Console.WriteLine($"{Answer}");
			}
    }
}
