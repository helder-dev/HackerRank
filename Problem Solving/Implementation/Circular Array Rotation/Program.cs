using System;

namespace Circular_Array_Rotation {
    class Program {
        public static void CircularArrayRotation(int[] ar, int k, int[] queries) {
            k %= ar.Length;

            for (int i = 0; i < queries.Length; i++) {
                Console.WriteLine(ar[(ar.Length - k + queries[i]) % ar.Length]);
            }
        }

        static void Main(string[] args) {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);
            int k = Convert.ToInt32(nkq[1]);
            int q = Convert.ToInt32(nkq[2]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int[] queries = new int[q];

            for (int i = 0; i < q; i++) {
                queries[i] = Convert.ToInt32(Console.ReadLine());
            }

            CircularArrayRotation(ar, k, queries);
        }
    }
}