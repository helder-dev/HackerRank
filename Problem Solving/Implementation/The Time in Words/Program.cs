using System;

namespace The_Time_in_Words {
    class Program {
        public static string TimeInWords(int h, int m) {
            string[] numberNames = {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",  "nineteen",
                "twenty",  "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine"
            };

            string minutesWord = m == 1 ? "minute" : "minutes";

            if (m == 0) {
                return string.Format("{0} o' clock", numberNames[h]);
            } else if (m == 15) {
                return string.Format("quarter past {0}", numberNames[h]);
            } else if (m == 30) {
                return string.Format("half past {0}", numberNames[h]);
            } else if (m == 45) {
                return string.Format("quarter to {0}", numberNames[(h % 12) + 1]);
            } else if (m < 30) {
                return string.Format("{0} {1} past {2}", numberNames[m], minutesWord, numberNames[h]);
            } else {
                return string.Format("{0} {1} to {2}", numberNames[60 - m], minutesWord, numberNames[(h % 12) + 1]);
            }
        }

        static void Main(string[] args) {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = TimeInWords(h, m);

            Console.WriteLine(result);
        }
    }
}