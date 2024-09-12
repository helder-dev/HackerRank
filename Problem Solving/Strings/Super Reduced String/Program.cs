using System;
using System.Collections.Generic;

namespace Super_Reduced_String {
    class Program {
        public static string SuperReducedString(string inputString) {
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++) {
                if (charStack.Count == 0) {
                    charStack.Push(inputString[i]);
                } else if (inputString[i] == charStack.Peek()) {
                    charStack.Pop();
                } else {
                    charStack.Push(inputString[i]);
                }
            }

            if (charStack.Count > 0) {
                char[] charStackArray = charStack.ToArray();
                Array.Reverse(charStackArray);

                return new string(charStackArray);               
            } else {
                return "Empty String";
            }
        }

        static void Main(string[] args) {
            string s = Console.ReadLine();

            string result = SuperReducedString(s);

            Console.WriteLine(result);
        }
    }
}