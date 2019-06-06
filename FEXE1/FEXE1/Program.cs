using System;
using System.IO;


namespace FEXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"...";
            File.ReadAllText(path);
            Console.WriteLine(File.GetAttributes(path));
        }
    }
}
