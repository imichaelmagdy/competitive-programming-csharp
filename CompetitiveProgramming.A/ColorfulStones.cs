using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.A
{
    public class ColorfulStones
    {
        public static void Solve()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int p = 0;

            foreach (char c in t)
            {
                if (p == s.Length - 1)
                {
                    break;
                }

                if (c == s[p])
                {
                    p++;
                }
            }

            Console.WriteLine(p + 1);
        }
    }
}
