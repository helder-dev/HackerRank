using System;

namespace Beautiful_Triplets {
    class Program {
        public static int BeautifulTriplets(int d, int[] ar) {
            int beautifulTriplets = 0;

            for (int i = 0; i < ar.Length - 2; i++) {
                for (int j = i + 1; j < ar.Length - 1; j++) {
                    if ((ar[j] - ar[i]) == d) {
                        for (int k = j + 1; k < ar.Length; k++) {
                            if ((ar[k] - ar[j]) == d) {
                                beautifulTriplets++;
                            }
                        }
                    }
                }
            }

            return beautifulTriplets;
        }

        static void Main(string[] args) {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = BeautifulTriplets(d, ar);

            Console.WriteLine(result);
        }
    }
}