using System;
using System.Linq;

namespace Designer_PDF_Viewer {
    class Program {
        public static int DesignerPdfViewer(int[] ar, string word) {
            return word.Max(x => ar[x - 'a']) * word.Length;;
        }

        static void Main(string[] args) {
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            string word = Console.ReadLine();

            int result = DesignerPdfViewer(ar, word);

            Console.WriteLine(result);
        }
    }
}