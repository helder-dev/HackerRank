using System;

namespace The_Grid_Search {
    class Program {
        public static string GridSearch(string[] grid, string[] pattern) {
            int gridSize = grid.Length;
            int patternSize = pattern.Length;

            for (int i = 0; i <= gridSize - patternSize; i++) {
                int gridRowStringSize = grid[0].Length;
                int patternRowStringSize = pattern[0].Length;

                for (int j = 0; j <= gridRowStringSize - patternRowStringSize; j++) {
                    bool found = true;

                    for (int k = 0; k < patternSize; k++) {
                        if (!grid[i + k].Substring(j, pattern[0].Length).Equals(pattern[k])) {
                            found = false;
                            break;
                        }
                    }

                    if (found)return "YES";
                }
            }

            return "NO";
        }

        static void Main(string[] args) {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < numberOfTestCases; i++) {
                string[] gridParameters = Console.ReadLine().Trim().Split(' ');

                int gridRows = Convert.ToInt32(gridParameters[0]);
                int gridColumns = Convert.ToInt32(gridParameters[1]);

                string[] grid = new string[gridRows];
                for (int row = 0; row < gridRows; row++) {
                    grid[row] = Console.ReadLine();
                }

                string[] patternParameters = Console.ReadLine().Trim().Split(' ');

                int patternRows = Convert.ToInt32(patternParameters[0]);
                int patternColumns = Convert.ToInt32(patternParameters[1]);

                string[] pattern = new string[patternRows];;
                for (int row = 0; row < patternRows; row++) {
                    pattern[row] = Console.ReadLine();
                }

                string result = GridSearch(grid, pattern);
                Console.WriteLine(result);
            }
        }
    }
}