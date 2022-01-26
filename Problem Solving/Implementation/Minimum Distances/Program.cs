using System;

namespace Minimum_Distances {
    class Program {
        public static int MinimumDistances(int[] ar) {
            int minDistance = -1;

            for (int i = 0; i < ar.Length; i++) {
                for (int j = i + 1; j < ar.Length; j++) {
                    if (ar[i] == ar[j]) {
                        if (minDistance == -1 || minDistance > (j - i)) {
                            minDistance = (j - i);
                        }
                        break;
                    }
                }
            }

            return minDistance;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int result = MinimumDistances(ar);

            Console.WriteLine(result);
        }
    }
}