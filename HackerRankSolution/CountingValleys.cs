using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankSolution
{
    //https://www.hackerrank.com/challenges/counting-valleys/problem
    public static class CountingValleys
    {
        public static int CountingValley(int n, string s)
        {
            int[] array = new int[n];
            int levelCount = 0;
            int numOfValleysCount = 0;

            foreach(char c in s)
            {
                if (c == 'U')
                    levelCount++;
                if (c == 'D')
                    levelCount--;

                if (levelCount == 0 && c == 'U')
                    numOfValleysCount++;
            }

            return numOfValleysCount;
        }
    }
}
