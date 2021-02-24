using System;

namespace Library_Fine {
    class Program {
        static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2) {
            if (y1 > y2) return 10000;
            if ((y1 == y2) && (m1 > m2)) return 500 * (m1 - m2);
            if ((y1 == y2) && (m1 == m2) && (d1 > d2)) return 15 * (d1 - d2);

            return 0;
        }

        static void Main(string[] args) {
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);
            int m1 = Convert.ToInt32(d1M1Y1[1]);
            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);
            int m2 = Convert.ToInt32(d2M2Y2[1]);
            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = LibraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }
    }
}