using System;

namespace Lisa_Workbook {
    class Program {
        public static int Workbook(int n, int k, int[] ar) {
            int specialProblems = 0;
            int pageNumber = 1;

            for (int i = 0; i < ar.Length; i++) {
                for (int j = 1; j <= ar[i]; j++) {
                    if (pageNumber == j) {
                        specialProblems++;
                    }

                    if ((j % k == 0) || (j == ar[i])) {
                        pageNumber++;
                    }
                }
            }

            return specialProblems;
        }

        static void Main(string[] args) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = Workbook(n, k, ar);

            Console.WriteLine(result);
        }
    }
}