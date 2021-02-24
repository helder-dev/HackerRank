using System;

namespace Append_and_Delete {
    class Program {
        public static string AppendAndDelete(string s, string t, int k) {
            if ((s.Length + t.Length) < k) return "Yes";

            int minLength = Math.Min(s.Length, t.Length);
            int matchingCharacters = 0;

            for (int i = 0; i < minLength; i++) {
                if (s[i] != t[i]) break;

                matchingCharacters++;
            }

            int minOperations = ((s.Length - matchingCharacters) + (t.Length - matchingCharacters));

            if (minOperations == k) return "Yes";
            if ((minOperations < k) && ((k - minOperations) % 2 == 0)) return "Yes";

            return "No";
        }

        static void Main(string[] args) {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = AppendAndDelete(s, t, k);

            Console.WriteLine(result);
        }
    }
}