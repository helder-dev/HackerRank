using System;
using System.Collections.Generic;

namespace Modified_Kaprekar_Numbers {
    class Program {
        static string KaprekarNumbers(int p, int q) {
            List<int> kaprekarNumbers = new List<int>();
    
            for (; p <= q; p++) {
                int digitCount = p.ToString().Length;
                string square = ((long)p * (long)p).ToString();

                long r = long.Parse(square.Substring(square.Length - digitCount));
                long l = 0;

                if (square.Length - digitCount > 0) {
                    l = long.Parse(square.Substring(0, square.Length - digitCount));
                }

                if (r + l == p) {
                    kaprekarNumbers.Add(p);
                }
            }

            if (kaprekarNumbers.Count > 0) {
                return string.Join(" ", kaprekarNumbers);
            } else {
                return "INVALID RANGE";
            }
        }

        static void Main(string[] args) {
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine(KaprekarNumbers(p, q));
        }
    }
}