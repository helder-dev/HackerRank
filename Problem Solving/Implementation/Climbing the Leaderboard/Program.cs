using System;
using System.Linq;

namespace Climbing_the_Leaderboard {
    class Program {
        static int[] ClimbingLeaderboard(int[] scores, int[] alice) {
            int[] ranking = scores.Distinct().ToArray();
            int totalRankingPositions = ranking.Length;

            int[] aliceRanking = new int[alice.Length];

            for (int i = 0; i < alice.Length; i++) {
                while (totalRankingPositions > 0) {
                    if (alice[i] >= ranking[totalRankingPositions - 1]) {
                        totalRankingPositions -= 1;
                    } else {
                        aliceRanking[i] = totalRankingPositions + 1;
                        break;
                    }
                }

                if (totalRankingPositions == 0) aliceRanking[i] = 1;
            }

            return aliceRanking;
        }

        static void Main(string[] args) {
            int scoresCount = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int aliceCount = Convert.ToInt32(Console.ReadLine());
            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] result = ClimbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}