using System;

namespace Save_the_Prisoner_ {
    class Program {
        static int SaveThePrisoner(int n, int m, int s) {
            return ((m - 1) + (s - 1)) % n + 1;
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);
                int m = Convert.ToInt32(nms[1]);
                int s = Convert.ToInt32(nms[2]);

                int result = SaveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }
    }
}