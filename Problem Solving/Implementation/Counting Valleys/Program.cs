using System;

namespace Counting_Valleys {
    class Program {
        public static int CountingValleys(int n, string s) {
            int level = 0;
            int valleys = 0;

            for (int i = 0; i < n; i++) {
                if (s[i] == 'U') {
                    if (++level == 0) {
                        valleys++;
                    }
                } else {
                    level--;
                }
            }

            return valleys;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = CountingValleys(n, s);

            Console.WriteLine(result);
        }
    }
}