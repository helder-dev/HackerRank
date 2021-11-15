using System;

namespace Bigger_is_Greater {
    class Program {
        public static string BiggerIsGreater(string w) {
            int wLength = w.Length;

            if (wLength == 1)return "no answer";

            char[] wCharArray = w.ToCharArray();

            int i = wLength - 1;
            while (i > 0 && wCharArray[i - 1] >= wCharArray[i]) {
                i--;
            }

            Console.WriteLine("i: " + i);

            if (i <= 0)return "no answer";

            int j = wLength - 1;
            while (wCharArray[j] <= wCharArray[i - 1]) {
                j--;
            }

            Console.WriteLine("j: " + j);

            char temp = wCharArray[i - 1];
            wCharArray[i - 1] = wCharArray[j];
            wCharArray[j] = temp;

            j = wLength - 1;
            while (i < j) {
                char temp2 = wCharArray[i];
                wCharArray[i] = wCharArray[j];
                wCharArray[j] = temp2;

                i++;
                j--;
            }

            return new string(wCharArray);
        }

        static void Main(string[] args) {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < T; i++) {
                string w = Console.ReadLine();

                Console.WriteLine(BiggerIsGreater(w));
            }
        }
    }
}