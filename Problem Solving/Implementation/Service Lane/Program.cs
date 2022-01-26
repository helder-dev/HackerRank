using System;
using System.Linq;

namespace Service_Lane {
    class Program {
        public static int[] ServiceLane(int[] width, int[][] cases) {
            int[] result = new int[cases.Length];

            for (int i = 0; i < cases.Length; i++) {
                result[i] = width.Skip(cases[i][0]).Take((cases[i][1] - cases[i][0]) + 1).ToArray().Min();
            }

            return result;
        }

        static void Main(string[] args) {
            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);
            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp));

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++) {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = ServiceLane(width, cases);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}