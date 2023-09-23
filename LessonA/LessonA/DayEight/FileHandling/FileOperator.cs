using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayEight.FileHandling
{
    public class FileOperator
    {
        public static void FileWriteAllLines()
        {
            string fname = @"c:\temp\myfileA.txt";
            string[] lines =
            {
                "Chennai is the capital city.",
                "Madurai is the Temple city",
                "Salem is the steal city"
            };
            try
            {
                File.WriteAllLines(fname, lines);
                Console.WriteLine("File Created");
            }
            catch (Exception err)
            {

                Console.WriteLine($"Error!!!{err.Message}");
            }
        }
        public static void FileReadAllText()
        {
            string line = string.Empty;
            string fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            string oldfName = @"c:\temp\myfileA.txt";
            string newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            string fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            string currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (string name in fileNames)
            {
                Console.WriteLine(name);
            }



            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*"); //*.* is
            foreach (string name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            string currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            string path = @"c:\temp\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }
        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            string path = @"c:\temp\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static void StreamWriterDemo()
        {
            string fName = @"c:\temp\myfileC.txt";
            string[] lines =
            {
              "Chennai is the capital city",
              "Madurai is the Temple city",
              "Salem is the steal city"
            };
            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
            Console.WriteLine("File Created");
        }
        public static void StreamReaderFromFileDemo()
        {
            StringBuilder line = new StringBuilder(250);
            string fName = @"c:\temp\myfileA.txt";
            using (StreamReader sr = new StreamReader(fName))
            {
                line.Append(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    line.Append(sr.ReadLine());
                    line.Append(Environment.NewLine);
                }
                Console.WriteLine(line.ToString());
            }
            Console.WriteLine("Completed");
        }
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if (_logoBytes == null)
                {
                    _logoBytes = File.ReadAllBytes(@"C:\temp\naruto");
                }
                return _logoBytes;
            }
        }
    }
}
