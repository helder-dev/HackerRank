using System;
using System.Linq;

namespace Migratory_Birds {
    class Program {
        public static int MigratoryBirds(int[] ar) {
            int[] birdTypes = new int[5];

            for (int i = 0; i < ar.Length; i++) {
                birdTypes[ar[i] - 1]++;
            }

            return Array.IndexOf(birdTypes, birdTypes.Max()) + 1;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = MigratoryBirds(ar);

            Console.WriteLine(result);
        }
    }
}