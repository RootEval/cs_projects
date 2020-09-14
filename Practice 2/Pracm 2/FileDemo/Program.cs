using System;
using System.IO;

namespace FileDemo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            StreamWriter writer = File.CreateText(@"C:\newfile.txt"); 
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?");
            writer.Close();
        }
    }
}
