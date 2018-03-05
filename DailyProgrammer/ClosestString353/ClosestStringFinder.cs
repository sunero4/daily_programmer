using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.ClosestString353
{
    //Challenge description at:
    //https://www.reddit.com/r/dailyprogrammer/comments/826coe/20180305_challenge_353_easy_closest_string/
    internal class ClosestStringFinder
    {
        private IStringDistance _stringDistanceCalculator;

        public ClosestStringFinder(IStringDistance stringDistance)
        {
            _stringDistanceCalculator = stringDistance;
        }

        public string FindClosestString(string[] strings)
        {
            //Each index of the array is the distance of the string at the corresponding index in the string
            //array
            var distances = new int[strings.Length];

            for (int i = 0, n = strings.Length; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    var tempDistance = _stringDistanceCalculator.CalculateDistance(strings[i], strings[j]);
                    distances[i] += tempDistance;
                    distances[j] += tempDistance;
                }
            }

            var resultIndex = GetIndexOfValue(distances.Min(), distances);
            return strings[resultIndex];
        }
        public int GetIndexOfValue(int value, int[] distances)
        {
            for (int i = 0, n = distances.Length; i < n; i++)
            {
                if (value == distances[i])
                {
                    return i;
                }
            }
            throw new ArgumentException("No match.");
        }
    }
}
