using System;
using System.Linq;

namespace Birthday_Cake_Candles {
    class Program {
        private static int BirthdayCakeCandles(int[] ar) {
            int max = ar.Max();

            return ar.Count(x => x == max);
        }

        static void Main(string[] args) {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = BirthdayCakeCandles(ar);

            Console.WriteLine(result);
        }
    }
}