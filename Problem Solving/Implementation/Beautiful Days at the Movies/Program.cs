using System;

namespace Beautiful_Days_at_the_Movies {
    class Program {
        public static int Reverse(int i) {
            int reverse = 0;

            while (i > 0) {
                reverse = (reverse * 10) + (i % 10);
                i = i / 10;
            }

            return reverse;
        }

        public static int BeautifulDays(int i, int j, int k) {
            int count = 0;

            for (; i <= j; i++) {
                if ((i - Reverse(i)) % k == 0) count++;
            }

            return count;
        }

        static void Main(string[] args) {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);
            int j = Convert.ToInt32(ijk[1]);
            int k = Convert.ToInt32(ijk[2]);

            int result = BeautifulDays(i, j, k);

            Console.WriteLine(result);
        }
    }
}