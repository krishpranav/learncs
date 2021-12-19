using System;

namespace Calculator {
    class NumberCal {
        public int FindMax(int num1, int num2) {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        static void Main(string[] args) {
            int a = 100;
            int b = 200;
            int ret;
            NumberCal n = new NumberCal();

            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is: {0}", ret);
        }
    }
}