using System;
using System.Linq;

namespace Angry_Professor {
    class Program {
        public static string AngryProfessor(int k, int[] ar) {
            return ar.Count(x => x <= 0) < k ? "YES" : "NO";
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);
                int k = Convert.ToInt32(nk[1]);

                int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

                string result = AngryProfessor(k, ar);

                Console.WriteLine(result);
            }
        }
    }
}