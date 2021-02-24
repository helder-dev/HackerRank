using System;

namespace Sherlock_and_Squares {
    class Program {
        private static int Squares(int a, int b) {
            return Convert.ToInt32(Math.Floor(Math.Sqrt(b)) - Math.Floor(Math.Sqrt(a - 1)));
        }

        static void Main(string[] args) {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);
                int b = Convert.ToInt32(ab[1]);

                int result = Squares(a, b);

                Console.WriteLine(result);
            }
        }
    }
}