using System;

namespace Grading_Students {
    class Program {
        public static int GradingStudent(int grade) {
            if (grade < 38) {
                return grade;
            } else {
                int mod = (grade % 5);
                if (mod == 0) {
                    return grade;
                } else if ((5 - mod) < 3) {
                    return grade + (5 - mod);
                } else {
                    return grade;
                }
            }
        }

        static void Main(string[] args) {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < gradesCount; i++) {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());

                Console.WriteLine(GradingStudent(gradesItem));
            }
        }
    }
}