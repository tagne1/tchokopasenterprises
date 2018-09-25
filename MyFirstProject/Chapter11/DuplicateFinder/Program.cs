﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace DuplicateFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recurseIntoSubdirectories = false;

            if (args.Length < 1)
            {
                ShowUsage();
                return;
            }

            int firstDirectoryIndex = 0;
            IEnumerable<string> directoriesToSearch = null;
            bool testDirectoriesMade = false;

            try
            {
                // Check to see if we are running in test mode
                if (args.Length == 1 && args[0] == "/test")
                {
                    directoriesToSearch = MakeTestDirectories();
                    testDirectoriesMade = true;
                    recurseIntoSubdirectories = true;
                }
                else
                {
                    if (args.Length > 1)
                    {
                        // see if we're being asked to recurse
                        if (args[0] == "/sub")
                        {
                            if (args.Length < 2)
                            {
                                ShowUsage();
                                return;
                            }
                            recurseIntoSubdirectories = true;
                            firstDirectoryIndex = 1;
                        }
                    }

                    // Get list of directories from command line.
                    directoriesToSearch = args.Skip(firstDirectoryIndex);
                }
                List<FileNameGroup> filesGroupedByName =
                    InspectDirectories(recurseIntoSubdirectories, directoriesToSearch);

                DisplayMatches(filesGroupedByName);
                Console.ReadKey();
            }
            finally
            {
                if (testDirectoriesMade)
                {
                    CleanupTestDirectories(directoriesToSearch);
                }
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine("Find duplicate files");
            Console.WriteLine("====================");
            Console.WriteLine(
                "Looks for possible duplicate files in one or more directories");
            Console.WriteLine();
            Console.WriteLine(
                "Usage: findduplicatefiles [/sub] DirectoryName [DirectoryName] ...");
            Console.WriteLine("/sub - recurse into subdirectories");
            Console.ReadKey();
        }

        private static List<FileNameGroup> InspectDirectories(
            bool recurseIntoSubdirectories,
            IEnumerable<string> directoriesToSearch)
        {
            var searchOption = recurseIntoSubdirectories ?
                SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            // Get the path of every file in every directory we're searching.
            var allFilePaths = from directory in directoriesToSearch
                               from file in Directory.GetFiles(directory, "*.*",
                                                                searchOption)
                               select file;

            // Group the files by local filename (i.e. the filename without the
            // containing path), and for each filename, build a list containing the
            // details for every file that has that filename.
            var fileNameGroups = from filePath in allFilePaths
                                 let fileNameWithoutPath = Path.GetFileName(filePath)
                                 group filePath by fileNameWithoutPath into nameGroup
                                 select new FileNameGroup
                                 {
                                     FileNameWithoutPath = nameGroup.Key,
                                     FilesWithThisName =
                                      (from filePath in nameGroup
                                       let info = new FileInfo(filePath)
                                       select new FileDetails
                                       {
                                           FilePath = filePath,
                                           FileSize = info.Length
                                       }).ToList()
                                 };

            return fileNameGroups.ToList();
        }

        private static void DisplayMatches(
            IEnumerable<FileNameGroup> filesGroupedByName)
        {
            var groupsWithMoreThanOneFile = from nameGroup in filesGroupedByName
                                            where nameGroup.FilesWithThisName.Count > 1
                                            select nameGroup;

            foreach (var fileNameGroup in groupsWithMoreThanOneFile)
            {
                // Group the matches by the file size, then select those
                // with more than 1 file of that size.
                var matchesBySize = from file in fileNameGroup.FilesWithThisName
                                    group file by file.FileSize into sizeGroup
                                    where sizeGroup.Count() > 1
                                    select sizeGroup;

                foreach (var matchedBySize in matchesBySize)
                {
                    string fileNameAndSize = string.Format("{0} ({1} bytes)",
                    fileNameGroup.FileNameWithoutPath, matchedBySize.Key);
                    WriteWithUnderlines(fileNameAndSize);
                    // Show each of the directories containing this file
                    foreach (var file in matchedBySize)
                    {
                        Console.WriteLine(Path.GetDirectoryName(file.FilePath));
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void WriteWithUnderlines(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(new string('-', text.Length));
        }

        // Example 11-15. Configuring access control on new directories
        private static string[] MakeTestDirectories()
        {
            string localApplicationData = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                @"Programming CSharp\FindDuplicates");

            // Get the name of the logged in user
            string userName = WindowsIdentity.GetCurrent().Name;
            // Make the access control rule
            FileSystemAccessRule fsarAllow =
                new FileSystemAccessRule(
                    userName,
                    FileSystemRights.FullControl,
                    AccessControlType.Allow);
            DirectorySecurity ds = new DirectorySecurity();
            ds.AddAccessRule(fsarAllow);

            // Example 11-16. Denying permissions
            FileSystemAccessRule fsarDeny =
                new FileSystemAccessRule(
                    userName,
                    FileSystemRights.WriteExtendedAttributes,
                    AccessControlType.Deny);
            ds.AddAccessRule(fsarDeny);

            // Let's make three test directories
            var directories = new string[3];
            for (int i = 0; i < directories.Length; ++i)
            {
                string directory = Path.GetRandomFileName();
                // Combine the local application data with the
                // new random file/directory name
                string fullPath = Path.Combine(localApplicationData, directory);
                // And create the directory
                Directory.CreateDirectory(fullPath, ds);
                directories[i] = fullPath;
                Console.WriteLine(fullPath);
            }
            // Example 11-18. Creating files in the test directories
            CreateTestFiles(directories);
            return directories;
        }

        // Example 11-17. Deleting a directory
        private static void CleanupTestDirectories(IEnumerable<string> directories)
        {
            foreach (var directory in directories)
            {
                Directory.Delete(directory);
            }
        }

        // Example 11-19. The CreateTestFiles method
        private static void CreateTestFiles(IEnumerable<string> directories)
        {
            string fileForAllDirectories = "SameNameAndContent.txt";
            string fileSameInAllButDifferentSizes = "SameNameDifferentSize.txt";
            int directoryIndex = 0;
            // Let's create a distinct file that appears in each directory
            foreach (string directory in directories)
            {
                directoryIndex++;
                // Create the distinct file for this directory
                string filename = Path.GetRandomFileName();
                string fullPath = Path.Combine(directory, filename);
                CreateFile(fullPath, "Example content 1");
                // And now the one that is in all directories, with the same content
                fullPath = Path.Combine(directory, fileForAllDirectories);
                CreateFile(fullPath, "Found in all directories");
                // And now the one that has the same name in
                // all directories, but with different sizes
                fullPath = Path.Combine(directory, fileSameInAllButDifferentSizes);
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Now with");
                builder.AppendLine(new string('x', directoryIndex));
                CreateFile(fullPath, builder.ToString());
            }
        }

        // Example 11-20. Writing a string into a new file
        private static void CreateFile(string fullPath, string contents)
        {
            File.WriteAllText(fullPath, contents);
        }
    }

}
