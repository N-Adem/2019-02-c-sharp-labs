using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // file - code that could possibly crash
            try
            {
                // File read as string 
                string data01 = File.ReadAllText("file.txt");
                Console.Write(data01);
            } // specific - handling the exception
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Phil says make that file!");
            }
            finally // always run regardless
            {
                Console.WriteLine("and make it quick");
            }
         

           
        }
    }
}
