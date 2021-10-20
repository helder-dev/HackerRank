using System;

namespace ACM_ICPC_Team {
    class Program {

        public static void ACMTeam(int n, int m, string[] topics) {
            int teams = 0;
            int knownTopics = 0;
            int maxKnownTopics = 0;

            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    knownTopics = 0;

                    for (int k = 0; k < m; k++) {
                        if ((topics[i][k] == '1') || (topics[j][k] == '1')) {
                            knownTopics++;
                        }
                    }

                    if (knownTopics == maxKnownTopics) {
                        teams++;
                    } else if (knownTopics > maxKnownTopics) {
                        maxKnownTopics = knownTopics;
                        teams = 1;
                    }
                }
            }

            Console.WriteLine(maxKnownTopics);
            Console.WriteLine(teams);
        }

        static void Main(string[] args) {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            string[] topics = new string[n];

            for (int i = 0; i < n; i++) {
                topics[i] = Console.ReadLine();
            }

            ACMTeam(n, m, topics);
        }
    }
}