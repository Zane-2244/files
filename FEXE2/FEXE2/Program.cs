using System;
using System.IO;


namespace FEXE2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"...";
            File.ReadAllText(path);
            Directory.GetFiles(path);
            Console.WriteLine(Path.GetExtension(path));

        }
    }
}
