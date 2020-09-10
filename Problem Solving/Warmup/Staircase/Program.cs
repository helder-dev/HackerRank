using System;

namespace Staircase {
    class Program {
        private static void Staircase(int n) {
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));
            }
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);
        }
    }
}