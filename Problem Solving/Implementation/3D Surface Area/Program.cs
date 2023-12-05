using System;

namespace _3D_Surface_Area {
    class Program {
        public static int SurfaceArea(int height, int width, int[][] board) {
            int totalArea = 0;

            int[] rowOffset = { -1, 0, 1, 0 };
            int[] colOffset = { 0, 1, 0, -1 };

            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    for (int k = 0; k < rowOffset.Length; k++) {
                        int adjacentRow = i + rowOffset[k];
                        int adjacentCol = j + colOffset[k];

                        int adjacentArea = (adjacentRow >= 0 && adjacentRow < height && adjacentCol >= 0 && adjacentCol < width) ? board[adjacentRow][adjacentCol] : 0;
                        int currentArea = board[i][j];
                        
                        totalArea += Math.Max(0, currentArea - adjacentArea);
                    }
                }
            }

            totalArea += height * width * 2; // Top and Bottom

            return totalArea;
        }

        static void Main(string[] args) {
            string[] hw = Console.ReadLine().Split(' ');

            int height = Convert.ToInt32(hw[0]);
            int width = Convert.ToInt32(hw[1]);

            int[][] board = new int[height][];

            for (int i = 0; i < height; i++) {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int result = SurfaceArea(height, width, board);

            Console.WriteLine(result);
        }
    }
}