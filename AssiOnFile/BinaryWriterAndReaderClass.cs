using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssiOnFile
{
    class BinaryWriterAndReaderClass
    {
            public static void Writer()
            {
                try
                {
                    
                    FileStream fs = new FileStream(@"J:\Binary.txt", FileMode.OpenOrCreate,
                    FileAccess.Write, FileShare.ReadWrite);

                Console.WriteLine("We are writing in BInary.txt using stream BinaryWriter");
                    BinaryWriter bw = new BinaryWriter(fs);

                    
                    string name = "vrushali";
                    int age = 22;
                    double height = 5.1;
                    char gender = 'F';


                    bw.Write(name);
                    bw.Write(age);
                    bw.Write(height);                  
                    bw.Write(gender);

                    bw.Close();
                    Console.WriteLine();
                }

                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        private static void Reader()
        {
            try
            {

                FileStream fin = new FileStream(@"J:\Binary.txt", FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);
                Console.WriteLine("We are Reading from BInary.txt using stream BinaryReader");

                BinaryReader br = new BinaryReader(fin);
                br.BaseStream.Seek(0, SeekOrigin.Begin);

                string name = br.ReadString();
                int age = br.ReadInt32();
                double height = br.ReadDouble();
                char gender = br.ReadChar();

                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Height :" + height);
                Console.WriteLine("Gender M/F:" + gender);


                br.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main()
        {
            BinaryWriterAndReaderClass bw = new BinaryWriterAndReaderClass();
            BinaryWriterAndReaderClass.Writer();
            BinaryWriterAndReaderClass.Reader();

        }
    }
}
