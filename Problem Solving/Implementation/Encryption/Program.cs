using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Encryption {
    class Program {
        public static void Encryption(string s) {
            string trimmedString = Regex.Replace(s, @"\s+", "");

            int columns = (int)Math.Ceiling(Math.Sqrt(trimmedString.Length));

            for (int i = 0; i < columns; i++) {
                var counter = 0;
                while (i + (counter * columns) < trimmedString.Length) {
                    Console.Write(trimmedString[i + (counter * columns)]);
                    counter++;
                }
                Console.Write(' ');
            }
        }

        static void Main(string[] args) {
            string s = Console.ReadLine();

            Encryption(s);
        }
    }
}