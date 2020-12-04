using System;

namespace Drawing_Book {
    class Program {
        static int PageCount(int n, int p) {
            return Math.Min(p / 2, n / 2 - p / 2);
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", PageCount(n, p));
        }
    }
}