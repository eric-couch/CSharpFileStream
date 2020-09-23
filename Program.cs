using System;
using System.IO;

namespace FS
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a file requires a filestream and a streamwriter
            FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter textFile = new StreamWriter(fs);
            textFile.Write("I changed this.  it should create a new file.");
            textFile.Write("I'm adding this too!");
            textFile.Close();

            // read from a file requires a filestream and a streamreader
            FileStream fr = new FileStream("testRead.txt", FileMode.Open, FileAccess.Read);
            StreamReader textReader = new StreamReader(fr);
            Console.WriteLine(textReader.ReadLine());
            Console.WriteLine(textReader.ReadLine());
            Console.WriteLine(textReader.ReadLine());
            textReader.Close();
        }
    }
}
