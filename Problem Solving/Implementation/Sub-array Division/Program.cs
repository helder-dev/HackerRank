using System;

namespace Sub_array_Division {
    class Program {
        public static int Birthday(int[] ar, int d, int m) {
            int sum = 0,
                count = 0;

            for (int i = 0; i < ar.Length; i++) {
                sum += ar[i];

                if (i >= m)sum -= ar[i - m];
                if (sum == d && i >= m - 1)count++;;
            }

            return count;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);

            int result = Birthday(ar, d, m);

            Console.WriteLine(result);
        }
    }
}