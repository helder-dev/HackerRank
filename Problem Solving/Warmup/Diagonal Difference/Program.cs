using System;

namespace Diagonal_Difference {
    class Program {
        public static int DiagonalDifference(int[][] ar) {
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < ar.Length; i++) {
                firstDiagonal = firstDiagonal + ar[i][i];
                secondDiagonal = secondDiagonal + ar[i][(ar.Length - 1) - i];
            }

            return Math.Abs(firstDiagonal - secondDiagonal);
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] ar = new int[n][];

            for (int i = 0; i < n; i++) {
                ar[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            }

            int result = DiagonalDifference(ar);

            Console.WriteLine(result);
        }
    }
}