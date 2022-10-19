using System;

namespace Fair_Rations {
    class Program {
        public static int FairRations(int[] ar) {
            int minLoaves = 0;

            for (int i = 0; i < ar.Length - 1; i++) {
                if (ar[i] % 2 == 1) {
                    ar[i]++;
                    ar[i + 1]++;

                    minLoaves += 2;
                }
            }

            if (ar[ar.Length - 1] % 2 == 1) {
                return -1;
            } else {
                return minLoaves;
            }
        }

        static void Main(string[] args) {
            int length = Convert.ToInt32(Console.ReadLine().Trim());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = FairRations(ar);

            Console.WriteLine(result == -1 ? "NO" : result);
        }
    }
}