using System;

namespace Cavity_Map {
    class Program {
        public static char[, ] CavityMap(int length, char[, ] cavities) {
            for (int row = 1; row < length - 1; row++) {
                for (int col = 1; col < length - 1; col++) {
                    if ((cavities[row - 1, col] < cavities[row, col]) &&
                        (cavities[row, col + 1] < cavities[row, col]) &&
                        (cavities[row + 1, col] < cavities[row, col]) &&
                        (cavities[row, col - 1] < cavities[row, col])) {

                        cavities[row, col] = 'X';
                    } 
                }
            }

            return cavities;
        }

        static void Main(string[] args) {
            int length = Convert.ToInt32(Console.ReadLine().Trim());

            char[, ] cavities = new char[length, length];
            for (int i = 0; i < length; i++) {
                char[] row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < length; j++) {
                    cavities[i, j] = row[j];
                }
            }

            char[, ] cavityMap = CavityMap(length, cavities);
            for (int i = 0; i < length; i++) {
                for (int j = 0; j < length; j++) {
                    Console.Write(cavityMap[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}