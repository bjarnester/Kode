﻿using System;
using System.IO;
using static System.Console;
using static System.IO.Directory;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithFilesystems
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputFileSystemInfo();
            WorkWithDrives();
            WorkingWithDirectories();
            WorkWithFiles();
        }

        static void WorkWithFiles()
        {

            var dir = Combine(GetFolderPath(SpecialFolder.Personal), "Kode", "Kapittel 9", "Output");
            CreateDirectory(dir);

            string textFile = Combine(dir, "Dummy.txt");
            string backup = Combine(dir, "dummy.bak");
            WriteLine($"Working with: {textFile}");

            WriteLine($"File esxists? .. {File.Exists(textFile)}");
            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("Hello, C#!");
            textWriter.Close();
            WriteLine($"File esxists? .. {File.Exists(textFile)}");
            File.Copy(sourceFileName: textFile, destFileName: backup, overwrite: true);
            WriteLine($"Exists? {File.Exists(textFile)}");
            File.Delete(textFile);
            File.Delete(backup);


        }

        static void WorkingWithDirectories()
        {

            var newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "Kode", "Kapittel 9", "NY");

            WriteLine($"Eksisterer? {Exists(newFolder)}");

            CreateDirectory(newFolder);
            WriteLine(newFolder);

            WriteLine($"Eksisterer? {Exists(newFolder)}");

            WriteLine("Sletter folder...");
            Delete(newFolder, recursive: true);

        }
        static void OutputFileSystemInfo()
        {
            WriteLine("{0,-33} {1}", "Path.PathSeparator", PathSeparator);
            WriteLine("{0,-33} {1}", "Path.PathDirectorySeparatorChar", DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", "Directory.GetCurrentDirectory()", GetCurrentDirectory());
            WriteLine("{0,-33} {1}", "Environment.CurrentDirectory()", CurrentDirectory);
            WriteLine("{0,-33} {1}", "Environment.SystemDirectory()", SystemDirectory);
            WriteLine("{0,-33} {1}", "Path.GetTempPath()", GetTempPath());
            WriteLine("GetFolderPath(SpecialFolder");
            WriteLine("{0,-33} {1}", " .System)", GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}", " .ApplicationData", GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}", " .MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}", " .Personal)", GetFolderPath(SpecialFolder.Personal));
        }

        static void WorkWithDrives()
        {

            WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}", "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {

                if(drive.IsReady)
                {

                    WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}", drive.Name, drive.DriveType, drive.DriveFormat, drive.TotalSize, drive.AvailableFreeSpace);

                }
                else
                {

                    WriteLine("{0,-30} | {1,-10} ", drive.Name, drive.DriveType);

                }

            }

        }
    }

    
}
