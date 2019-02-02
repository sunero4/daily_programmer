using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.AdditivePersistence374
{
    public class AdditivePersistence
    {
        public int CalculateAdditivePersistence(int number)
        {
            var count = 0;
            var digits = number;
            do
            {
                count++;
                digits = GetSumOfDigits(digits);
            } while (digits > 9);

            return count;
        }

        private int GetSumOfDigits(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
