using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.RepeatingNumbers341
{
    internal class RepeatingNumbers
    {
        public IEnumerable<RepeatedNumber> FindRepeatingNumbers(string number)
        {
            var possibleRepetitions = new List<string>();
            var repeatingNumbers = new List<RepeatedNumber>();

            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    var tempNumber = number.Skip(i).Take(j).ToString();
                    possibleRepetitions.Add(tempNumber);
                }
            }



            return repeatingNumbers;
        }

    }

    internal class RepeatedNumber
    {
        public string Number { get; set; }
        public int NumberOfOccurrences { get; set; }
    }
}
