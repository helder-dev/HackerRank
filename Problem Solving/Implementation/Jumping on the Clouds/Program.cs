using System;

namespace Jumping_on_the_Clouds {
    class Program {
        public static int JumpingOnClouds(int[] ar) {
            int jumps = 0;

            for (int i = 0; i < ar.Length; i++) {
                if ((i + 2) < ar.Length && ar[i + 2] == 0) {
                    jumps++;
                    i++;
                } else if ((i + 1) < ar.Length && ar[i + 1] == 0) {
                    jumps++;
                }
            }

            return jumps;
        }
        
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = JumpingOnClouds(ar);

            Console.WriteLine(result);
        }
    }
}