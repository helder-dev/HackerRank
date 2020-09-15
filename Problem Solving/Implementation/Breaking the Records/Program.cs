using System;
using System.Linq;

namespace Breaking_the_Records {
    class Program {
        public static int[] BreakingRecords(int[] scores) {
            int highestScore = scores.First(),
                lowestScore = scores.First(),
                increased = 0,
                decreased = 0;

            for (int i = 0; i < scores.Length; i++) {
                if (scores[i] > highestScore) {
                    highestScore = scores[i];
                    increased++;
                } else if (scores[i] < lowestScore) {
                    lowestScore = scores[i];
                    decreased++;
                }
            }

            return new int[] { increased, decreased };;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int[] result = BreakingRecords(scores);

            Console.WriteLine("{0}", string.Join(" ", result));
        }
    }
}