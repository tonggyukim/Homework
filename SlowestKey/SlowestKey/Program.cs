using System;

namespace SlowestKey
{
    class Program
    {
        public string SlowestKeyFinder(int [] releaseTimes, string [] keysPressed)
        {
            int maxDiff = releaseTimes[0];
            int maxIndex = 0;

            for (int i = 1; i<releaseTimes.Length -1; i++)
            {
                int currentDiff = releaseTimes[i] - releaseTimes[i - 1];
                if (currentDiff > maxDiff)
                {
                    maxDiff = currentDiff;
                    maxIndex = i;
                }
                else if (currentDiff == maxDiff && keysPressed[i] > keysPressed[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return keysPressed[maxIndex];

        }

        static void Main(string[] args)
        {
            Console.Write("What were the release times?: ");
            string releaseTimes = Console.ReadLine();
            string[] releaseTimesArray = releaseTimes.Split(',',' ');
            int [] convertedArray = new int[releaseTimesArray.Length];
            for (int i=0; i<releaseTimesArray.Length; i++)
            {
                convertedArray[i] = int.Parse(releaseTimesArray[i]);
            }
            Console.Write("What were the keys that were pressed?: ");
            string keysPressed = Console.ReadLine();
            string[] keysPressedArray = keysPressed.Split(',', ' ');
            Program answer = new Program();
            string slowestKey = answer.SlowestKeyFinder(convertedArray, keysPressedArray);
            Console.WriteLine($"Slowest key is {slowestKey}");
        }
    }
}
