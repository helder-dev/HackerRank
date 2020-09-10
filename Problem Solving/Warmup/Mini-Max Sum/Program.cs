using System;
using System.Linq;

namespace Mini_Max_Sum {
    class Program {
        private static void MiniMaxSum(int[] ar) {
            Array.Sort(ar);

            Console.WriteLine(
                String.Format("{0} {1}",
                    ar.Reverse().Skip(1).Sum(x => Convert.ToInt64(x)),
                    ar.Skip(1).Sum(x => Convert.ToInt64(x))
                )
            );
        }

        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            MiniMaxSum(arr);
        }
    }
}