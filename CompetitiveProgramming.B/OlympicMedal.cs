using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming.B
{
  public class OlympicMedal
  {
    public static void Solve()
    {
      string[] OuterRadii = Console.ReadLine().Split(' ');
      string[] OuterDensities = Console.ReadLine().Split(' ');
      string[] InnerDensities = Console.ReadLine().Split(' ');
      string[] AB = Console.ReadLine().Split(' ');

      int OuterRadius = OuterRadii.Skip(1).Select(int.Parse).Max();
      int OuterDensity = OuterDensities.Skip(1).Select(int.Parse).Max();
      int InnerDensity = InnerDensities.Skip(1).Select(int.Parse).Min();
      int A = int.Parse(AB[0]);
      int B = int.Parse(AB[1]);

      double InnerRadius = Math.Sqrt((OuterDensity * B * Math.Pow(OuterRadius, 2)) / (OuterDensity * B + InnerDensity * A));
      Console.WriteLine(InnerRadius);
    }
  }
}