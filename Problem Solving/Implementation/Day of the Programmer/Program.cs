using System;

namespace Day_of_the_Programmer {
    class Program {
        public static string DayOfProgrammer(int year) {
            if (year < 1918) { // Julian
                if (year % 4 == 0)return $"12.09.{year}";
            } else if (year > 1918) { // Gregorian
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) return $"12.09.{year}";
            } else { // Transaction Year
                return $"26.09.{year}";
            }

            return $"13.09.{year}";
        }
        static void Main(string[] args) {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = DayOfProgrammer(year);

            Console.WriteLine(result);
        }
    }
}