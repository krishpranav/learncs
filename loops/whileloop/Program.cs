using System;

namespace WhileLoop {
    class Loop {
        static void Main(string[] args) {
            int a = 10;

            while (a < 20) {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
        }
    }
}