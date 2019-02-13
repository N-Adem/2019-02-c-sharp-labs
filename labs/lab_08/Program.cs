using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
//using static System.Console;

namespace lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string data01 = File.ReadAllText("file.txt");
            Console.WriteLine(data01);

            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);
            Console.WriteLine("\n\n\n ");
            Console.WriteLine($"\n\n\n{data02}");

            string[] data3 = File.ReadAllLines("file.txt");
            Console.WriteLine(data3[0]);
            Console.WriteLine(data3[1]);
            Console.WriteLine(data3[2]);
            // Write to file      
            File.WriteAllText("file2.txt", "here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));
            File.WriteAllLines("file3.txt", data3);
            Console.WriteLine("\nAnd read it back\n");
            Console.WriteLine(File.ReadAllText("file3.txt"));
            // Copy file --------------------------------------------------------
            File.Copy("file.txt", "coppyoffile1.txt", true); // overwrite if true
            // delete file ------------------------------------------------------
            File.Delete("copyoffile1.txt");
            // Checking if file exists ------------------------------------------
            Console.WriteLine("\ndoes my file exist?\n");
            Console.WriteLine(File.Exists("file.txt"));
            // Get the time the file was created --------------------------------
            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));
            // Extra Info 
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);
            // creating directories
            Directory.CreateDirectory("folderA");
            Directory.CreateDirectory("folderb");
            File.Create("foldera/abc.txt");
            var fileArray = Directory.GetFiles("foldera");
            Console.WriteLine(fileArray[0]);

        }
    }
}
