using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.A
{
    public class CalculatingFunction
    {
        public static void Solve()
        {
            BigInteger lastIndex;
            BigInteger.TryParse(Console.ReadLine(), out lastIndex);

            BigInteger sum = lastIndex % 2 == 0 ? lastIndex / 2 : - (lastIndex / 2) - 1;

            Console.WriteLine(sum);
        }
    }
}
