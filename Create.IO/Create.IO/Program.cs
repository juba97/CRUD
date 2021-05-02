using System;
using System.IO;

namespace Create.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Create();
            Console.WriteLine("Complete");
        }
        static void Create()
        {
            string path = @"D:\test.txt";
            using var Sw = new StreamWriter(path, true);
            string data = Console.ReadLine();
            Sw.WriteLine(data);
        }
    }
}
