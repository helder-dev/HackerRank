using System;

namespace Picking_Numbers {
    class Program {
        static int PickingNumbers(int n, int[] a) {
            int retValue = 0;

            for (int i = 0; i < n; i++) {
                int count = 0;

                for (int j = 0; j < n; j++) {
                    if (((a[i] - a[j]) >= 0) && ((a[i] - a[j]) <= 1)) {
                        count++;
                    }
                }

                if (count > retValue) retValue = count;
            }

            return retValue;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            Console.WriteLine("{0}", PickingNumbers(n, a));
        }
    }
}