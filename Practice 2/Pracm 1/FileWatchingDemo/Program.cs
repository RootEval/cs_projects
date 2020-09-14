using System;
using System.IO;

namespace FileWatchingDemo {
    class Program {
        static void Main(string[] args) {
            FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);
            //FileSystemWatcher watcher = new FileSystemWatcher(@"\"); // to test without admin rights
            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.EnableRaisingEvents = true;
            Console.ReadKey(); // force main thread to stay
        }

        static void watcher_Changed(object sender, FileSystemEventArgs e) {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
    }
}
