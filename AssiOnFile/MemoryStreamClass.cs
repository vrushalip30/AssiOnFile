using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssiOnFile
{
    class MemoryStreamClass
    {
        static void Main()
        {
            MemoryStreamClass m = new MemoryStreamClass();
            m.UseMemoryStream1();
            m.UseMemoryStream();
        }
        //The MemoryStream is one of the basic Stream classes.
        // It deals with data directly in memory, as the name implies and
        // its often used to deal with bytes coming from another place,
        // e.g.a file or a network location, without locking the source.

        //MemoryStream, which locks and unlocks the file again immediately,
        // and then start working on the bytes in a MemoryStream.
        // If you need to do a lot of seeking back and forth in the bytes this is also much faster than doing the same directly in
        // e.g.a FileStream because the bytes in a MemoryStream is stored in memory instead of on the disk.
        public void UseMemoryStream1()
        {
            byte[] fileContents = File.ReadAllBytes(@"J:\File2.txt");
            using (MemoryStream memoryStream = new MemoryStream(fileContents))
            {
                using (TextReader textReader = new StreamReader(memoryStream))
                {
                    string line;
                    while ((line = textReader.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
        }
        public void UseMemoryStream()
        {
            byte[] fileContents = File.ReadAllBytes(@"J:\File2.txt");
            using (MemoryStream memoryStream = new MemoryStream(fileContents))
            {
                int b;
                while ((b = memoryStream.ReadByte()) >= 0)
                    Console.WriteLine(Convert.ToChar(b));
            }
        }
    }
}
//The MemoryStream class can be used as the backing source for data you want to keep in memory.
// This makes it a great temporary storage for data coming from a file or a network resource,
// to prevent lockups etc. while you work with the data.

