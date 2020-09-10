using System;

namespace Compare_the_Triplets {
    class Program {
        private static int[] CompareTriplets(int[] arA, int[] arB) {
            int scoreA = 0,
                scoreB = 0;

            for (int i = 0; i < arA.Length; i++) {
                if (arA[i] > arB[i]) {
                    scoreA++;
                } else if (arA[i] < arB[i]) {
                    scoreB++;
                }
            }

            return new int[] { scoreA, scoreB };
        }

        static void Main(string[] args) {
            int[] arA = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] arB = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int[] score = CompareTriplets(arA, arB);

            Console.WriteLine(String.Join(" ", score));
        }
    }
}