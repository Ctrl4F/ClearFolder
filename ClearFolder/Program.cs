using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            DeleteAllfiles();
            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }
            
        }
        //a function to delete all the files
        public static void DeleteAllfiles()
        {
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);
            foreach(FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }
        //a function to delete all the folders
        public static void DeleteAllFolders(string DirectoryName, bool ifExists)
        {
            if (Directory.Exists(DirectoryName))
            {
                Directory.Delete(DirectoryName, true);
            }else if (ifExists)
            {
                throw new SystemException("No such directory to delete");
            }
        }
    }
}
