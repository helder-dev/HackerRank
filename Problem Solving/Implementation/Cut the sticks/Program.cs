using System;
using System.Linq;

namespace Cut_the_sticks {
    class Program {
        public static void CutTheSticks(int[] ar) {
            while (ar.Count() > 0) {
                Console.WriteLine(ar.Count());

                int min = ar.Min();
                ar = ar.Select(x => x - min).Where(x => x > 0).ToArray();
            }
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            CutTheSticks(ar);
        }
    }
}