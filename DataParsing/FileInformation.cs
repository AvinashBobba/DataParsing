using System;
using System.IO;
using System.Linq;

namespace DataParsing
{
    public class FileInformation
    {
        public void FileDetails()
        {

            string path = @"C:\Users\avinash.bobba\DirectoryInfo\avinash.txt"; 
            string destPath = @"C:\Users\avinash.bobba\Directory\bobba.txt";

            //FileInfo fileInfo = new FileInfo(path);
            ////fileInfo.MoveTo(path);
            //fileInfo.CopyTo(destPath);

            //Enumerable.Repeat('a', 1024 * 1024);

            File.CreateText(destPath).Close();
            File.Move(path, destPath);

            FileInfo fileInfo = new FileInfo(path); fileInfo.MoveTo(destPath);
            foreach (string file in Directory.GetFiles(@"C:\Users\avinash.bobba\DirectoryInfo"))
            {
                Console.WriteLine(Directory.GetFiles(@"C:\Users\avinash.bobba\DirectoryInfo").Count());

                if (File.Exists(@"C:\Users\avinash.bobba\DirectoryInfo\avinash.txt"))
                    File.Delete(@"C:\Users\avinash.bobba\DirectoryInfo\avinash.txt");

                Console.WriteLine(Directory.GetFiles(@"C:\Users\avinash.bobba\DirectoryInfo").Count());
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\avinash.bobba\DirectoryInfo");

            foreach (FileInfo fileInf in directoryInfo.GetFiles())
            {
                Console.WriteLine(fileInf.FullName);
            }

        }
    }
}
