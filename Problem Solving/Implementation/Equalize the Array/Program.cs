using System;
using System.Linq;

namespace Equalize_the_Array {
    class Program {
        public static int EqualizeArray(int[] ar) {
            return ar.Length - ar.GroupBy(x => x).Select(x => x.Count()).OrderByDescending(x => x).First();
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = EqualizeArray(ar);

            Console.WriteLine(result);
        }
    }
}