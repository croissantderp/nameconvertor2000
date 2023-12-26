using System;
using System.IO;

namespace nameconvertor2000
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader file = new(@"D:\Documents\wd.txt");
            string enter = file.ReadToEnd().Replace("\n", "\" , \"").Replace("\r", "");

            using StreamWriter file2 = new(@"D:\Documents\wd2.txt");
            file2.Write("\"" + enter + "\"");

            Console.WriteLine("done");
        }
    }
}
