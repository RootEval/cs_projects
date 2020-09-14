using System;
using System.IO;

namespace FileDemo {
    class Program {
        static void Main(string[] args) {
            // part 1
            StreamWriter writer = File.CreateText(@"c:\newfile.txt"); 
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?");
            writer.Close();

            // part 2
            StreamReader reader = File.OpenText(@"c:\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}
