using System;
using System.Linq;

namespace Between_Two_Sets {
    class Program {
        public static int GetTotalX(int[] ar, int[] br, int lenght) {
            int total = 0;

            for (int i = 1; i <= 100; i++) {
                if (ar.Any(x => i % x != 0))continue;
                if (br.Any(x => x % i != 0))continue;

                total++;
            }

            return total;
        }

        static void Main(string[] args) {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] br = Array.ConvertAll(Console.ReadLine().Split(' '), brTemp => Convert.ToInt32(brTemp));

            int total = GetTotalX(ar, br, Math.Max(n, m));

            Console.WriteLine(total);
        }
    }
}