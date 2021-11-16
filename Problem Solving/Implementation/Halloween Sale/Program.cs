using System;

namespace Halloween_Sale {
    class Program {
        public static int HowManyGames(int p, int d, int m, int s) {
            int numberOfGames = 0;
            while (s > 0 && (s - p) >= 0) {
                numberOfGames++;
                s -= p;

                if ((p - d) > m) {
                    p -= d;
                } else {
                    p = m;
                };
            }

            return numberOfGames;
        }

        static void Main(string[] args) {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int s = Convert.ToInt32(firstMultipleInput[3]);

            Console.WriteLine(HowManyGames(p, d, m, s));
        }
    }
}