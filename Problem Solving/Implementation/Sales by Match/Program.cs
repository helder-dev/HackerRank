using System;
using System.Linq;

namespace Sales_by_Match {
    class Program {
        public static int SockMerchant(int[] ar) {
            return ar.GroupBy(x => x).Select(group => group.Count() / 2).Sum();
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SockMerchant(ar);

            Console.WriteLine(result);
        }
    }
}