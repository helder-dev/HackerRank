using System;

namespace Flatland_Space_Stations {
    class Program {
        public static bool IsSpaceStation(int value, int[] c) {
            for (int i = 0; i < c.Length; i++) {
                if (value == c[i]) return true;
            }

            return false;
        }

        public static int FlatlandSpaceStations(int n, int[] c) {
            int maxDistance = 0;
            int start = 0;
            int end = n - 1;

            int currentDistance = 0;
            bool firstFound = false;

            for (int i = 0; i < n; i++) {
                if (IsSpaceStation(i, c)) {
                    if (!firstFound) {
                        maxDistance = Math.Abs(start - i);
                        firstFound = true;
                        start = i;
                    } else {
                        currentDistance = Math.Abs(i - start) / 2;
                        start = i;
                    }
                    maxDistance = Math.Max(currentDistance, maxDistance);
                }
            }

            if (end - start > 1) {
                currentDistance = Math.Abs(start - end);
                maxDistance = Math.Max(currentDistance, maxDistance);
            }

            return maxDistance;
        }

        static void Main(string[] args) {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            Console.WriteLine(FlatlandSpaceStations(n, c));
        }
    }
}