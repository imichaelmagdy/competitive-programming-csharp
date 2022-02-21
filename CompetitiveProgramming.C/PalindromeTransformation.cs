using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.C
{
    public class PalindromeTransformation
    {
        public static void Solve()
        {
            string[] firstLineArguments = Console.ReadLine().Split(' ');
            string text = Console.ReadLine();

            int charCount = int.Parse(firstLineArguments[0]);
            int position = int.Parse(firstLineArguments[1]) - 1;            // Zero indexing

            if (position >= charCount / 2)
            {
                position = mirrorCharIndex(charCount, position);
            }

            int firstCharToChange = position;
            int lastCharToChange = position;

            int sumOfDifferencesBetweenChars = 0;

            for (int i = 0; i < charCount / 2; i++)
            {
                char character = text[i];
                char mirrorCharacter = text[mirrorCharIndex(charCount, i)];
                if (character != mirrorCharacter)
                {
                    firstCharToChange = Math.Min(i, firstCharToChange);
                    lastCharToChange = Math.Max(i, lastCharToChange);
                    int differenceBetweenChars = getDifferenceBetweenChars(character, mirrorCharacter);
                    sumOfDifferencesBetweenChars += differenceBetweenChars;
                }
            }

            int totalMovesCount = sumOfDifferencesBetweenChars + getLateralMovesCount(firstCharToChange, lastCharToChange, position);

            Console.WriteLine(totalMovesCount);
        }

        private static int mirrorCharIndex(int charCount, int position)
        {
            return charCount - position - 1;
        }

        private static int getDifferenceBetweenChars(char first, char second)
        {
            int difference = Math.Abs(first - second);
            int minDifference = Math.Min(difference, 26 - difference);

            return minDifference;
        }

        private static int getLateralMovesCount(int firstCharToChange, int lastCharToChange, int position)
        {
            int movesToFirst = Math.Abs(position - firstCharToChange);
            int movesToLast = Math.Abs(position - lastCharToChange);
            int lateralMovesCount = lastCharToChange - firstCharToChange + Math.Min(movesToFirst, movesToLast);

            return lateralMovesCount;
        }

    }
}
