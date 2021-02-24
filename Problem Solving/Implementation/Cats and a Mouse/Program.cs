using System;

namespace Cats_and_a_Mouse {
    class Program {
        static string CatAndMouse(int x, int y, int z) {
            if (Math.Abs(z - x) < Math.Abs(z - y)) {
                return "Cat A";
            } else if (Math.Abs(z - x) > Math.Abs(z - y)) {
                return "Cat B";
            } else {
                return "Mouse C";
            }
        }

        static void Main(string[] args) {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++) {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);
                int y = Convert.ToInt32(xyz[1]);
                int z = Convert.ToInt32(xyz[2]);

                Console.WriteLine("{0}", CatAndMouse(x, y, z));
            }
        }
    }
}