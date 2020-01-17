using System;

namespace FilesAndFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFilesAndFolders = new Folder()
            {
                Name = "/",
                FileNames = new[] { "RootFile1.txt", "RootFile2.txt", "RootFile3.txt"}, 
                Subfolders = new[]
                {
                    new Folder()
                    {
                        FileNames = new[] { "AbcFile1.txt", "AbcFile2.txt", "AbcFile3.txt"},
                    }, 
                    new Folder() 
                }
            };
        }
    }
}
