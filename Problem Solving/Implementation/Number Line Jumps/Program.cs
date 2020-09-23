using System;

namespace Number_Line_Jumps {
    class Program {
        public static void Kangaroo(int x1, int v1, int x2, int v2) {
            if ((v1 > v2) && ((x2 - x1) % (v1 - v2) == 0)) {
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }
        }

        static void Main(string[] args) {
            string[] values = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(values[0]);
            int v1 = Convert.ToInt32(values[1]);
            int x2 = Convert.ToInt32(values[2]);
            int v2 = Convert.ToInt32(values[3]);

            Kangaroo(x1, v1, x2, v2);
        }
    }
}