using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Path();
        }

        static void Path()
        {
            string filepatch = @"D:\Test.txt";
            //string[] lines = File.ReadAllLines(filepatch);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepatch).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.Write("\nEnter a name to enter in the text document: ");
            lines.Add(Console.ReadLine());
            File.WriteAllLines(filepatch, lines);
            
        }
    }
}
