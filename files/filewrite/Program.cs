using System;
using System.IO;

namespace FileWrite {
    class Program {
        static void Main(string[] args) {
            string writeText = "Hello Everyone you can see me in text file";
            File.WriteAllText("hello.txt", writeText);
        } 
    }
}