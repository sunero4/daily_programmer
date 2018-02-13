using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingMySpending350
{
    public class AccountBalancing
    {
        /// <summary>
        /// Finds the points where the sums of the sub-sequences before and after are equal. Should be
        /// O(n) (or, O(2n) as the sums are pre-calculated so there is no need to traverse the array for each
        /// check
        /// </summary>
        /// <param name="spendings">Array of spendings</param>
        /// <param name="length">Length of the array</param>
        /// <returns>Points where the sub-sequences before and after are equal</returns>
        public IEnumerable<int> EquilibriaPoints(int[] spendings, int length)
        {
            var sums = AddSums(spendings);

            var equilibriaPoints = new List<int>();

            if (sums[sums.Length - 1] == 0)
            {
                equilibriaPoints.Add(0);
            }
            for (int i = 1, n = sums.Length; i < n; i++)
            {
                if (sums[i - 1] == sums[sums.Length - 1] - sums[i])
                {
                    equilibriaPoints.Add(i);
                }
            }
            return equilibriaPoints;
        }

        /// <summary>
        /// Computes the sum of the elements in the supplied array and adds them to an array
        /// </summary>
        /// <param name="spendings">Array of spendings</param>
        /// <returns>An array of sums</returns>
        private int[] AddSums(int[] spendings)
        {
            var sum = 0;
            var sums = new int[spendings.Length];
            for (int i = 0, n = spendings.Length; i < n; i++)
            {
                sum += spendings[i];
                sums[i] = sum;
            }

            return sums;
        }

    }
}
