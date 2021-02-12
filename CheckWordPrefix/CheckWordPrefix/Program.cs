using System;

namespace CheckWordPrefix
{
    public class Solution
    {
        public int CheckWord(string sentence, string searchWord)
        {
            string[] words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord))
                {
                    return i + 1;
                }
            }
            return -1;
        }
        public string MakeString(int number)
        {
            switch (number)
            {
                case 1: return "1st";
                case 2: return "2nd";
                case 3: return "3rd";
                default: return $"{number}-th";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a search word: ");
            string searchWord = Console.ReadLine();
            Solution solution = new Solution();
            int position = solution.CheckWord(sentence, searchWord);
            if (position <= 0)
            {
                Console.WriteLine($"\"{searchWord}\" is not in any word of the sentence \"{sentence}");
            }
            else
            {
                string positionInWord = solution.MakeString(position);
                Console.WriteLine($"\"{searchWord}\" is the {positionInWord} word of the sentence \"{sentence}\"");
            }
                
        }
    }
}
