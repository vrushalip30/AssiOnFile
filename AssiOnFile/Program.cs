using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssiOnFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string data=" ";
            FileStream fs = new FileStream(@"J:\User.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter your text untill (End)");
            
            

            while (!data.Contains("End")) 
            {

                data = Console.ReadLine();
                sw.WriteLine(data);


            } 
            sw.Close();
            fs.Close();

            FileStream fs1 = new FileStream(@"J:\User.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs1);
            Console.WriteLine("reading from userfile1:\n");
            Console.WriteLine( sr.ReadToEnd());
            sr.Close();
            fs1.Close();


        }
    }
}

