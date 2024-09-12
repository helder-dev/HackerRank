using System;

namespace Absolute_Permutation {
    class Program {
        public static int[] AbsolutePermutation(int n, int k) {
            int[] absolutePermutationArray = new int[n];

            if (k == 0) { // No swap needed
                for (int i = 0; i < n; i++) {
                    absolutePermutationArray[i] = i + 1;
                }

                return absolutePermutationArray;
            }

            if (k != 0 && n % (k * 2) != 0) { // If no absolute permutation exists, return -1
                return new int[] { -1 };
            }

            for (int i = 0; i < n; i++) {
                if ((i / k) % 2 == 0) {
                    absolutePermutationArray[i] = i + k + 1;
                } else {
                    absolutePermutationArray[i] = i - k + 1;
                }
            }

            return absolutePermutationArray;
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                int[] result = AbsolutePermutation(n, k);

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}