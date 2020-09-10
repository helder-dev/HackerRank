using System;
using System.Linq;

namespace Simple_Array_Sum {
    class Program {
        private static int SimpleArraySum(int[] ar) {
            return ar.Sum();
        }

        static void Main(string[] args) {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SimpleArraySum(ar);

            Console.WriteLine(result);
        }
    }
}