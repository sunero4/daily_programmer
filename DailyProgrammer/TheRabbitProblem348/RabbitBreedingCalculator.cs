using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.TheRabbitProblem348
{
    internal class RabbitBreedingCalculator
    {
        private long[] _maleRabbits;
        private long[] _femaleRabbits;

        public RabbitBreedingCalculator()
        {
            _maleRabbits = new long[96];
            _femaleRabbits = new long[96];
        }

        public Tuple<int, long> MonthsBeforeWorldDomination(int numberOfMaleRabbits, int numberOfFemaleRabbits, long rabbitsNeeded)
        {
            _maleRabbits[2] = numberOfMaleRabbits;
            _femaleRabbits[2] = numberOfFemaleRabbits;

            long totalRabbits = numberOfMaleRabbits + numberOfFemaleRabbits;
            long deadRabbits = 0;
            var months = 0;

            while (totalRabbits < rabbitsNeeded)
            {
                var fertileRabbits = _femaleRabbits.Skip(4).Sum();

                var males = new long[1] {fertileRabbits * 5};
                var females = new long[1] {fertileRabbits * 9};
                deadRabbits += _femaleRabbits[_femaleRabbits.Length - 1] + _maleRabbits[_maleRabbits.Length - 1];

                _maleRabbits = males.Concat(_maleRabbits.Take(_maleRabbits.Length - 1)).ToArray();
                _femaleRabbits = females.Concat(_femaleRabbits.Take(_femaleRabbits.Length - 1)).ToArray();

                totalRabbits = _femaleRabbits.Sum() + _maleRabbits.Sum();
                months++;
            }
            return Tuple.Create(months, deadRabbits);
        }

        public void PrintResult(int months, long deadRabbits)
        {
            Console.WriteLine($"After {months} months, the rabbits achieved total world domination. {deadRabbits} rabbits died in the process.");
        }
    }
}
