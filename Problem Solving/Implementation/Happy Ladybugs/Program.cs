using System;
using System.Collections.Generic;

namespace Happy_Ladybugs {
    class Program {
        public static string HappyLadybugs(int numberOfCells, string board) {
            Dictionary<char, int> colorFrequency = new Dictionary<char, int>();

            foreach (char letter in board) {
                if (colorFrequency.ContainsKey(letter)) {
                    colorFrequency[letter]++;
                } else {
                    colorFrequency[letter] = 1;
                }
            }

            // Verify if each color has at least a frequency of 2
            foreach (var frequency in colorFrequency) {
                if (frequency.Value < 2 && frequency.Key != '_') {
                    return "NO";
                }
            }

            // Verify if it contains an empty cell
            if (colorFrequency.ContainsKey('_')) {
                return "YES";
            } else {
                // If it has no empty cell, check if it is already in order
                int count = 1;

                for (int i = 1; i < board.Length; i++) {
                    if (board[i] == board[i - 1]) {
                        count++;
                        continue;
                    } else {
                        if (count < 2) {
                            return "NO";
                        } else {
                            count = 1;
                        }
                    }
                }

                return "YES";
            }
        }

        static void Main(string[] args) {
            int numberOfGames = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < numberOfGames; i++) {
                int numberOfCells = Convert.ToInt32(Console.ReadLine().Trim());

                string board = Console.ReadLine();

                string result = HappyLadybugs(numberOfCells, board);
                Console.WriteLine(result);
            }
        }
    }
}