using System;
using System.IO;
using static System.Console;

namespace _011_Files
{
    class Tester
    {
        public void TestFile(string folder)
        {
            WriteLine($"Testing folder: {folder}");
            DirectoryInfo di = new DirectoryInfo(folder);
            if(!di.Exists) throw new Exception($"Root folder ({folder}) don't exist.");

            // Create subfolder
            var sub = di.CreateSubdirectory("Test");
            WriteLine($"Folder: {sub.FullName} created.");
            // Create file
            string fileName = Path.Combine(sub.FullName, "Test.txt");
            WriteLine($"Creating file {fileName}");
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                for(int i = 0; i < 10; i++)
                    writer.WriteLine(i.ToString());
                writer.Flush();
                writer.Close();
            }
            FileInfo fi = new FileInfo(fileName);
            WriteLine("File info:");
            WriteLine($"    Creation time: {fi.CreationTime}");
            WriteLine($"    Length: {fi.Length}");
            // Delete file and folder
            WriteLine("Delete file and folder");
            FileInfo[] fis = sub.GetFiles("*.*", SearchOption.AllDirectories);
            foreach(FileInfo f in fis)
            {
                Console.WriteLine($"    File: {f.FullName}");
                f.Delete();
            }
            Console.WriteLine($"    Folder: {sub.FullName}");
            sub.Delete(true);
        }
    }
}
