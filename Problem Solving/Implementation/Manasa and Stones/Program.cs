using System;
using System.Linq;

namespace Manasa_and_Stones {
    class Program {
        public static int[] Stones(int n, int a, int b) {
            int[] lastStonesValues = new int[n];

            for (int i = 0; i < n; i++) {
                lastStonesValues[i] = (i * a) + ((n - 1 - i) * b);
            }

            Array.Sort(lastStonesValues);

            return lastStonesValues.Distinct().ToArray();
        }

        static void Main(string[] args) {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++) {
                int n = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                int[] result = Stones(n, a, b);

                Console.WriteLine("{0}", string.Join(" ", result));
            }
        }
    }
}