using System;

namespace Chocolate_Feast {
    class Program {
        public static int ChocolateFeast(int n, int c, int m) {
            int chocolate = n / c;

            if (chocolate % (m - 1) == 0) {
                chocolate += (chocolate / (m - 1)) - 1;
            } else {
                chocolate += (chocolate / (m - 1));
            }

            return chocolate;
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);
                int c = Convert.ToInt32(ncm[1]);
                int m = Convert.ToInt32(ncm[2]);

                int result = ChocolateFeast(n, c, m);

                Console.WriteLine(result);
            }
        }
    }
}