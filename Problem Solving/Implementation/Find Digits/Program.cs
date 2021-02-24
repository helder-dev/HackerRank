using System;
using System.Linq;

namespace Find_Digits {
    class Program {
        public static int FindDigits(int n) {
            return n.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).Where(x => x > 0).Count(x => n % x == 0);
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = FindDigits(n);

                Console.WriteLine(result);
            }
        }
    }
}