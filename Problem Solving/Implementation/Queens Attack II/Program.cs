using System;
using System.Collections.Generic;

namespace Queens_Attack_II {
    class Program {
        public static int QueensAttack(int boardLength, int boardObstacles, int queenRowPosition, int queenColPosition, HashSet<(int, int)> obstacles) {
            int count = 0;

            // Define the eight possible directions the queen can attack
            int[] rowDirection = {-1, -1, 0, 1, 1, 1, 0, -1 };
            int[] colDirection = { 0, 1, 1, 1, 0, -1, -1, -1 };

            // Iterate through each direction
            for (int i = 0; i < 8; i++) {
                int row = queenRowPosition + rowDirection[i];
                int col = queenColPosition + colDirection[i];

                while (row >= 1 && row <= boardLength && col >= 1 && col <= boardLength) {
                    if (obstacles.Contains((row, col))) {
                        break; // Obstacle found, stop checking in this direction
                    } else {
                        count++; // Obstacle not found, the queen can attack this square
                    }

                    // Move to the next square in the current direction
                    row += rowDirection[i];
                    col += colDirection[i];
                }
            }

            return count;
        }

        static void Main(string[] args) {
            string[] boardParameters = Console.ReadLine().Trim().Split(' ');

            int boardLength = Convert.ToInt32(boardParameters[0]);
            int boardObstacles = Convert.ToInt32(boardParameters[1]);

            string[] queenParameters = Console.ReadLine().Trim().Split(' ');

            int queenRowPosition = Convert.ToInt32(queenParameters[0]);
            int queenColPosition = Convert.ToInt32(queenParameters[1]);

            HashSet<(int, int)> obstacleSet = new HashSet<(int, int)>();

            for (int i = 0; i < boardObstacles; i++) {
                int[] obstacle = Array.ConvertAll(Console.ReadLine().Split(' '), positionTemp => Convert.ToInt32(positionTemp));
                obstacleSet.Add((obstacle[0], obstacle[1]));
            }

            int result = QueensAttack(boardLength, boardObstacles, queenRowPosition, queenColPosition, obstacleSet);

            Console.WriteLine(result);
        }
    }
}