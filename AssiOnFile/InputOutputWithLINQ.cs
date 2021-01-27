using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssiOnFile
{
    class InputOutputWithLINQ
    {

        static void Main()
        {
            var startFolder = @"J:\DotnetBatchJan2021\ConsoleApps1\FileStreamClassDemo\FileStreamClassDemo\bin\Debug";
            DirectoryInfo dir = new DirectoryInfo(startFolder);
            var fileList = dir.GetFiles("*.*",SearchOption.AllDirectories);
            var fileQuery = from file in fileList
                            where file.Extension == ".txt"
                            orderby file.Name
                            select file;

            //var fileQuery1=fileList.Where(f =>f.Extension==".txt")
            Console.WriteLine("All files with . txt extension");
            foreach(var v in fileQuery)
            {
                Console.WriteLine(v.FullName+" " +v.Extension);
                
            }
        }
    }
}
