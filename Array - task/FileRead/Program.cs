using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string SampleFile = "SampleFile.txt";
            File.WriteAllText(SampleFile, "No matter what we breed we still are made of greed.");
            string contents = File.ReadAllText(SampleFile);
            contents = contents.ToUpper();
            string SampleFileCopy = "SampleFileCopy.txt";
            File.WriteAllText(SampleFileCopy, contents);
        }
    }
}