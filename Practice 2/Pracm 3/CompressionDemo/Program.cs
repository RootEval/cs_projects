using System;
using System.IO;
using System.IO.Compression;

namespace CompressionDemo {
    class Program {
        static void Main(string[] args) {
            //CompressFile(@"c:\boot.ini", @"c:\boot.ini.gz");
            CompressFile(@"c:\newfile.txt", @"c:\newfile.txt.gz");
            //UncompressFile(@"c:\boot.ini.gz", @"c:\boot.ini");
            DecompressFile(@"c:\newfile.txt.gz", @"c:\newfile_decompressed.txt");
        }

        static void CompressFile(string inFilename, string outFilename) {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1) {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
        }
        static void DecompressFile(string inFilename, string outFilename) {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream =
            new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1) {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();

        }

    }
}
