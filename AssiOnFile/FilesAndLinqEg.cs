using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssiOnFile
{
    class FilesAndLinqEg
    {
       
        static long GetFileLength(string filename)
        {
            long returnval;
            FileInfo fi;
            try
            {
                 fi = new FileInfo(filename);
                returnval = fi.Length;
            }
            catch(FileNotFoundException)
            {
                returnval = 0; 
            }
            finally

            {

            }
            return returnval;
        }
        static void Main()
        {
            var path = @"J:\DotnetBatchJan2021\ConsoleApps1\FileStreamClassDemo\FileStreamClassDemo\bin\Debug";
            var dir = new DirectoryInfo(path);
            var filelist = dir.GetFiles("*.*");
            var query = from file in filelist
                        select GetFileLength(file.FullName);
            var res1 = query.ToArray(); //cache result to avoid multiple trips to the directory
            var largestFile = res1.Max();
            var totalBytes = res1.Sum();
           // Console.WriteLine($"File Lengths:{res1}");
            Console.WriteLine($"Largest File:{largestFile}");
            Console.WriteLine($"Total Bytes : {totalBytes}");
            

        }
    }
}
