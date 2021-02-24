using System;

namespace Utopian_Tree {
    class Program {
        public static int UtopianTree(int n) {
            int height = 1;

            if (n == 0) return height;

            for (int i = 1; i <= n; i++) {
                height = i % 2 == 0 ? height + 1 : height * 2;
            }

            return height;
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++) {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = UtopianTree(n);

                Console.WriteLine(result);
            }
        }
    }
}