using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalancingMySpending350;

namespace DailyProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            var balancing = new AccountBalancing();

            var input = new int[8] { 0, -3, 5, -4, -2, 3, 1, 0 };
            var output = balancing.EquilibriaPoints(input, input.Length);

            var input1 = new int[11] {3, -2, 2, 0, 3, 4, -6, 3, 5, -4, 8};
            var output1 = balancing.EquilibriaPoints(input1, input1.Length);

            var input2 = new int[11] {9, 0, -5, -4, 1, 4, -4, -9, 0, -7, -1};
            var output2 = balancing.EquilibriaPoints(input2, input2.Length);

            var input3 = new int[11] {9, -7, 6, -8, 3, -9, -5, 3, -6, -8, 5};
            var output3 = balancing.EquilibriaPoints(input3, input3.Length);

            foreach (var i in output)
            {
                Console.WriteLine(i);
            }
            foreach (var i in output1)
            {
                Console.WriteLine(i);
            }
            foreach (var i in output2)
            {
                Console.WriteLine(i);
            }
            foreach (var i in output3)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
