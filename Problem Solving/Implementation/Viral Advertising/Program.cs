using System;

namespace Viral_Advertising {
    class Program {
        public static int ViralAdvertising(int n) {
            int peopleSharing = 5,
                cumulativeLikes = 2;

            for (int i = 1; i < n; i++) {
                peopleSharing = (peopleSharing / 2) * 3;
                cumulativeLikes += (peopleSharing / 2);
            }

            return cumulativeLikes;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = ViralAdvertising(n);

            Console.WriteLine(result);
        }
    }
}