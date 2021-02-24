using System;

namespace Sequence_Equation {
    class Program {
        private static void PermutationEquation(int[] ar) {
            for (int i = 1; i <= ar.Length; i++) {
                Console.WriteLine(Array.IndexOf(ar, Array.IndexOf(ar, i) + 1) + 1);
            }
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));

            PermutationEquation(ar);
        }
    }
}