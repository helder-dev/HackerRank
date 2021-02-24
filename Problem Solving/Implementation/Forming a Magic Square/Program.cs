using System;

namespace Forming_a_Magic_Square {
    class Program {

        static int FormingMagicSquare(int[][] s) {
            int[, , ] allPossibleSolutions = new int[8, 3, 3] { 
                { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } }, 
                { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } }, 
                { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } }, 
                { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } }, 
                { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } }, 
                { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } }, 
                { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } }, 
                { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } }
            };

            int minPermutationCost = int.MaxValue;

            for (int p = 0; p < allPossibleSolutions.GetLength(0); p++) {
                int permutationCost = 0;

                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        permutationCost += Math.Abs(s[i][j] - allPossibleSolutions[p,i,j]);
                    }
                }

                minPermutationCost = Math.Min(minPermutationCost, permutationCost);
            }

            return minPermutationCost;
        }

        static void Main(string[] args) {
            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++) {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = FormingMagicSquare(s);

            Console.WriteLine(result);
        }
    }
}