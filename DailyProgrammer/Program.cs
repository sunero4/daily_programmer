using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyProgrammer.TheRabbitProblem348;

namespace DailyProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbits = new RabbitBreedingCalculator();
            var result = rabbits.MonthsBeforeWorldDomination(2, 4, 15000000000);

            rabbits.PrintResult(result.Item1, result.Item2);
            Console.ReadLine();
        }
    }
}
