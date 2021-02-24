using System;
using System.Linq;

namespace Jumping_on_the_Clouds {
    class Program {
        public static int JumpingOnClouds(int[] ar, int k) {
            if (ar.Length % k != 0) return 80;

            return 100 - (ar.Length / k + (ar.Where((v, i) => i % k == 0).Sum() * 2));
        }

        static void Main(string[] args) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = JumpingOnClouds(ar, k);

            Console.WriteLine(result);
        }
    }
}