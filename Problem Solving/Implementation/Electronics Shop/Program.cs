using System;

namespace Electronics_Shop {
    class Program {
        static int GetMoneySpent(int n, int[] keyboards, int m, int[] drives, int b) {
            int total = 0;
            int moneySpent = -1;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    total = keyboards[i] + drives[j];

                    if (total < b && total > moneySpent) {
                        moneySpent = total;
                    } else if (total == b) {
                        return total;
                    }
                }
            }

            return moneySpent;
        }

        static void Main(string[] args) {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            Console.WriteLine("{0}", GetMoneySpent(n, keyboards, m, drives, b));
        }
    }
}