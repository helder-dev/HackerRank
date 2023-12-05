using System;

namespace Strange_Counter {
    class Program {
        public static long StrangeCounter(long t) {
            long limit = 3;

            while (t > limit) {
                t = t - limit;
                limit = limit * 2;
            }

            return limit + 1 - t;
        }

        static void Main(string[] args) {
            long t = Convert.ToInt64(Console.ReadLine().Trim());

            long result = StrangeCounter(t);
            Console.WriteLine(result);
        }
    }
}