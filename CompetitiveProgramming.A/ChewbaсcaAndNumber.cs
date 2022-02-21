using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.A
{
    public class ChewbaсcaAndNumber
    {
        public static void Solve()
        {
            string x = Console.ReadLine();
            int t;
            StringBuilder sb = new StringBuilder();
            bool ninesPassed = false;

            foreach (char c in x)
            {
                t = int.Parse(c.ToString());
                if (t != 9)
                {
                    ninesPassed = true;
                }
                if (t == 9)
                {
                    if (ninesPassed)
                    {
                        sb.Append(0);
                    }
                    else
                    {
                        sb.Append(9);
                        ninesPassed = true;
                    }
                } else
                {
                    sb.Append(Math.Min(t, 9 - t));
                }
            }

            Console.WriteLine(sb.ToString().TrimStart('0') == "" ? "0" : sb.ToString().TrimStart('0'));
        }
    }
}
