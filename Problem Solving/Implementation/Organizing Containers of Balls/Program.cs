using System;

namespace Organizing_Containers_of_Balls {
    class Program {
        public static bool OrganizingContainers(int n, int[][] containers) {
            int[] containersSize = new int[n];
            int[] amountOfBallsPerType = new int[n];

            for (int i = 0; i < n; i++) {
                int containerSize = 0;
                int amountOfBalls = 0;

                for (int j = 0; j < n; j++) {
                    containerSize += containers[i][j];
                    amountOfBalls += containers[j][i];
                }

                containersSize[i] = containerSize;
                amountOfBallsPerType[i] = amountOfBalls;
            }

            for (int i = 0; i < n; i++) {
                bool match = false;

                for (int j = 0; j < n; j++) {
                    if (containersSize[i] == amountOfBallsPerType[j]) {
                        match = true;
                        break;
                    }
                }

                if (!match)return false;
            }

            return true;
        }

        static void Main(string[] args) {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < q; i++) {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int[][] container = new int[n][];

                for (int j = 0; j < n; j++) {
                    container[j] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
                }

                Console.WriteLine(OrganizingContainers(n, container) ? "Possible" : "Impossible");
            }
        }
    }
}