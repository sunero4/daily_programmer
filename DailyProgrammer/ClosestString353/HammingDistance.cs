using System;

namespace DailyProgrammer.ClosestString353
{
    internal class HammingDistance : IStringDistance
    {
        public int CalculateDistance(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                throw new ArgumentException("Strings must be of equal length.");
            }
            var distance = 0;
            for (int i = 0, n = s1.Length; i < n; i++)
            {
                if (s1[i] != s2[i])
                {
                    distance++;
                }
            }
            return distance;
        }
    }
}