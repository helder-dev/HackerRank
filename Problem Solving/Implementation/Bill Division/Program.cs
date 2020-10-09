using System;
using System.Linq;

namespace Bill_Division {
    class Program {
        public static void BonAppetit(int[] ar, int k, int b) {
            int bill = (ar.Sum() - ar[k]) / 2;

            Console.WriteLine((bill == b) ? "Bon Appetit" : (b - bill).ToString());
        }

        static void Main(string[] args) {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            BonAppetit(ar, k, b);
        }
    }
}