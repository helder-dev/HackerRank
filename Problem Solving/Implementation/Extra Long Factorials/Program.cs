using System;
using System.Numerics;

namespace Extra_Long_Factorials {
    class Program {
        public static void ExtraLongFactorials(int n) {
            BigInteger fact = n;

            for (int i = (n - 1); i >= 1; i--) {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            ExtraLongFactorials(n);
        }
    }
}