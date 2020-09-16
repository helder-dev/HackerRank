using System;

namespace Divisible_Sum_Pairs {
    class Program {
        public static int DivisibleSumPairs(int n, int k, int[] ar) {
            int pairs = 0;

            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if ((ar[i] + ar[j]) % k == 0)pairs++;
                }
            }

            return pairs;
        }

        static void Main(string[] args) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = DivisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }
    }
}