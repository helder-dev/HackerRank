using System;
using System.Linq;

namespace Repeated_String {
    class Program {
        static long RepeatedString(string s, long n) {
            long numberOfLettersInSubString = s.Count(c => c.Equals('a'));
            if (numberOfLettersInSubString == 0) return 0;

            long numberOfCompletedSubStrings = (long)(n / s.Length);

            long frequencyOfFirstLetterInTheSubString = numberOfLettersInSubString * numberOfCompletedSubStrings;

            int remainder = (int)(n % s.Length);

            for (int i = 0; i < remainder; i++) {
                if (s[i].Equals('a')) frequencyOfFirstLetterInTheSubString++;
            }

            return frequencyOfFirstLetterInTheSubString;
        }

        static void Main(string[] args) {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}