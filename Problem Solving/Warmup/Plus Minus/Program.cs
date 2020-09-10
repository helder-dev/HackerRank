using System;
using System.Linq;

namespace Plus_Minus {
    class Program {
        private static void PlusMinus(int arCount, int[] ar) {
            Console.WriteLine(Math.Round(ar.Count(x => x > 0) / (decimal)arCount, 6));
            Console.WriteLine(Math.Round(ar.Count(x => x < 0) / (decimal)arCount, 6));
            Console.WriteLine(Math.Round(ar.Count(x => x == 0) / (decimal)arCount, 6));
        }

        static void Main(string[] args) {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            PlusMinus(arCount, ar);
        }
    }
}