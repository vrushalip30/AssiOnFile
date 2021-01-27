using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AssiOnFile
{
    class BufferedStreamClass
    {
        static void Main()
        {
            /* Buffering makes things faster—many bytes can be written at once, reducing overhead of each byte.
             The BufferedStream in C# can be used to optimize stream reads and writes.*/
            /*
                        With a buffer,
                        we avoid executing writes and reads until a certain
                        number of operations has been requested.Then we execute them all at once.*/
            var t1 = Stopwatch.StartNew();
            // Use BufferedStream to buffer writes to a MemoryStream.

            using (MemoryStream memory = new MemoryStream())
            using (BufferedStream stream = new BufferedStream(memory))
            {

                // Write a byte 5 million times.
                for (int i = 0; i < 5000000; i++)
                {
                    stream.WriteByte(5);
                }
            }
            t1.Stop();
            Console.WriteLine("BUFFEREDSTREAM TIME: " + t1.Elapsed.TotalMilliseconds);
        }
    }
}
