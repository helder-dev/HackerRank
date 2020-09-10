using System;
using System.Linq;

namespace A_Very_Big_Sum {
    class Program {
        private static long VeryBigSum(long[] ar) {
            return ar.Sum();
        }

        static void Main(string[] args) {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = VeryBigSum(ar);

            Console.WriteLine(result);
        }
    }
}