using System;
using System.IO;

namespace DataParsing
{
    public class DirectoryAccess
    {
        public void GetAccessDetails()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Program Files");
            ListDirectories(directoryInfo, "*a*", 5, 0);
        }

        private static void ListDirectories(DirectoryInfo directoryInfo, string searchPattern, int maxLevel, int currentLevel)
        {
            if (currentLevel >= maxLevel) { return; }

            string indent = new string('-', currentLevel);

            try
            {
                var subDirectories = directoryInfo.EnumerateDirectories(searchPattern);
                foreach (DirectoryInfo subDirectory in subDirectories) 
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1); 
                }
            }
            catch (UnauthorizedAccessException)
            {         // You don’t have access to this folder.        
                Console.WriteLine(indent + "Can’t access: " + directoryInfo.Name);
                return;
            }
            catch (DirectoryNotFoundException)
            {         // The folder is removed while iterating       
                Console.WriteLine(indent + "Can’t find: " + directoryInfo.Name);
                return;
            }
        }

    }
}
