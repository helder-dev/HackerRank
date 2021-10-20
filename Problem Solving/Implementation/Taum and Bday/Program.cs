using System;

namespace Taum_and_Bday {
    class Program {
        public static long TaumBday(long b, long w, long bc, long wc, long z) {
            if (bc > (wc + z))return (((b + w) * wc) + (b * z));

            if (wc > (bc + z))return (((b + w) * bc) + (w * z));

            return ((b * bc) + (w * wc));
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < t; i++) {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                long b = Convert.ToInt32(firstMultipleInput[0]);
                long w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                long bc = Convert.ToInt32(secondMultipleInput[0]);
                long wc = Convert.ToInt32(secondMultipleInput[1]);
                long z = Convert.ToInt32(secondMultipleInput[2]);

                Console.WriteLine(TaumBday(b, w, bc, wc, z));
            }
        }
    }
}