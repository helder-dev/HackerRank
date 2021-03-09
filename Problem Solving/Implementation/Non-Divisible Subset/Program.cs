using System;
using System.Linq;
using System.Collections.Generic;

namespace Non_Divisible_Subset {
    class Program {
        public static int NonDivisibleSubset(int k, List<int> s) {
            int[] remainders = new int[k];

            for (int i = 0; i < s.Count; i++) {
                remainders[s[i] % k]++;
            }

            int retValue = remainders[0] > 0 ? 1 : 0;

            for (int i = 1; i <= k / 2; i++) {
                if (i != k - i) {
                    retValue += Math.Max(remainders[i], remainders[k - i]);
                } else {
                    retValue++;
                }
            }

            return retValue;
        }
        
        static void Main(string[] args) {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = NonDivisibleSubset(k, s);

            Console.WriteLine(result);
        }
    }
}