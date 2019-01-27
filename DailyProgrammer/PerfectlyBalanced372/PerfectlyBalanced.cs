using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.PerfectlyBalanced372
{
    public class PerfectlyBalanced
    {
        public bool IsPerfectlyBalanced(string characters)
        {
            var countingArray = new int[26];

            if(characters.Length <= 0)
            {
                return true;
            }

            for (int i = 0; i < characters.Length; i++)
            {
                countingArray[characters[i] - 97]++;
            }

            var occuringCharacters = countingArray.Where(x => x > 0).ToArray();

            for (int i = 0; i < occuringCharacters.Length - 1; i++)
            {
                if(occuringCharacters[i] != occuringCharacters[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
