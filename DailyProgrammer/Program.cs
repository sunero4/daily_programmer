using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyProgrammer.ClosestString353;
using DailyProgrammer.RepeatingNumbers341;
using DailyProgrammer.TheRabbitProblem348;

namespace DailyProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rabbits = new RabbitBreedingCalculator();
            //var result = rabbits.MonthsBeforeWorldDomination(2, 4, 15000000000);

            //rabbits.PrintResult(result.Item1, result.Item2);

            //var repeatingNumbers = new RepeatingNumbers();
            //var results = repeatingNumbers.FindRepeatingNumbers("82156821568221");

            //foreach (var repeatedNumber in results)
            //{
            //    Console.WriteLine("The number {0} was repeated {1} times.", repeatedNumber.Number, repeatedNumber.NumberOfOccurrences);
            //}
            //Console.ReadLine();

            var closestStringCalculator = new ClosestStringFinder(new HammingDistance());
            var strings = new string [11]
            {
                "AACACCCTATA", "CTTCATCCACA", "TTTCAATTTTC", "ACAATCAAACC", "ATTCTACAACT",
                "ATTCCTTATTC", "ACTTCTCTATT", "TAAAACTCACC", "CTTTTCCCACC", "ACCTTTTCTCA", "TACCACTACTT"
            };
            var result1 = closestStringCalculator.FindClosestString(strings);
            Console.WriteLine(result1);

            var strings2 = new string[21]
            {
                "ACAAAATCCTATCAAAAACTACCATACCAAT", "ACTATACTTCTAATATCATTCATTACACTTT", "TTAACTCCCATTATATATTATTAATTTACCC",
                "CCAACATACTAAACTTATTTTTTAACTACCA", "TTCTAAACATTACTCCTACACCTACATACCT", "ATCATCAATTACCTAATAATTCCCAATTTAT",
                "TCCCTAATCATACCATTTTACACTCAAAAAC", "AATTCAAACTTTACACACCCCTCTCATCATC", "CTCCATCTTATCATATAATAAACCAAATTTA",
                "AAAAATCCATCATTTTTTAATTCCATTCCTT", "CCACTCCAAACACAAAATTATTACAATAACA", "ATATTTACTCACACAAACAATTACCATCACA",
                "TTCAAATACAAATCTCAAAATCACCTTATTT", "TCCTTTAACAACTTCCCTTATCTATCTATTC", "CATCCATCCCAAAACTCTCACACATAACAAC",
                "ATTACTTATACAAAATAACTACTCCCCAATA", "TATATTTTAACCACTTACCAAAATCTCTACT", "TCTTTTATATCCATAAATCCAACAACTCCTA",
                "CTCTCAAACATATATTTCTATAACTCTTATC", "ACAAATAATAAAACATCCATTTCATTCATAA", "CACCACCAAACCTTATAATCCCCAACCACAC",
            };
            var result2 = closestStringCalculator.FindClosestString(strings2);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
