using System;
using System.IO;
using System.IO.IsolatedStorage;


namespace IsolatedStorageDemo {
    class Program {
        static void Main(string[] args) {
            // part 1
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close();

            // part 2
            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0) {
                Console.WriteLine("File doest exist");
            } else {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStore);
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
                
            }
            Console.ReadKey();
        }
    }
}
