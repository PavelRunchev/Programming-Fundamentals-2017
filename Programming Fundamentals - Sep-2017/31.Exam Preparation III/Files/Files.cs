using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Files
{
    class File
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public ulong Size { get; set; }
    }
    class Directory
    {
        public string Name { get; set; }
        public List<File> Folder { get; set; }
    }
    class Files
    {
        static void Main()
        {
            List<Directory> dataDirectories = new List<Directory>();

            int numberOfFiles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfFiles; i++)
            {
                string[] inputDirectory = Console.ReadLine()
                    .Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                string root = inputDirectory[0];
                string[] tokens = inputDirectory[inputDirectory.Length - 1].Split(';').ToArray();
                string fileName = tokens[0];
                ulong size = ulong.Parse(tokens[1]);
                int indexDot = fileName.LastIndexOf('.');
                string extension = new string(fileName.Skip(indexDot + 1).ToArray());
                if (!dataDirectories.Any(a => a.Name == root))
                {
                    Directory directory = new Directory();
                    directory.Name = root;
                    directory.Folder = new List<File>();
                    File file = new File();
                    file.Name = fileName;
                    file.Extension = extension;
                    file.Size = size;
                    directory.Folder.Add(file);
                    dataDirectories.Add(directory);
                }
                else
                {
                    if (dataDirectories.Any(n => n.Name == root))
                    {
                        var currentRoot = dataDirectories.FirstOrDefault(r => r.Name == root);
                        if (currentRoot.Folder.Any(v => v.Name == fileName))
                        {
                            var currentFile = currentRoot.Folder.FirstOrDefault(c => c.Name == fileName);
                            currentFile.Name = fileName;
                            currentFile.Extension = extension;
                            currentFile.Size = size;
                        }
                        else
                        {
                            File file = new File();
                            file.Name = fileName;
                            file.Extension = extension;
                            file.Size = size;
                            currentRoot.Folder.Add(file);
                        }
                    }
                }
            }

            string[] inputQuery = Console.ReadLine().Split(' ');
            string searchExtension = inputQuery[0];
            string searchRoot = inputQuery[2];

            SearchDirectories(searchExtension, searchRoot, dataDirectories);
        }

        private static void SearchDirectories(string searchExtension, string searchRoot, List<Directory> dataDirectories)
        {
            var findedDirectory = dataDirectories.FirstOrDefault(s => s.Name == searchRoot);
            
            if(findedDirectory != null)
            {
                var findedFiles = findedDirectory.Folder.FirstOrDefault(n => n.Extension == searchExtension);
                if (findedFiles != null)
                {
                    foreach (File item in findedDirectory.Folder.OrderByDescending(w => w.Size).ThenBy(q => q.Name))
                    {
                        if (item.Extension == searchExtension)
                        {
                            Console.WriteLine($"{item.Name} - {item.Size} KB");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }              
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
