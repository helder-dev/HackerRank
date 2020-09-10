using System;

namespace Time_Conversion {
    class Program {
        private static string TimeConversion(string s) {
            return Convert.ToDateTime(s).ToString("HH:mm:ss");
        }

        static void Main(string[] args) {
            string s = Console.ReadLine();

            string result = TimeConversion(s);

            Console.WriteLine(result);
        }
    }
}