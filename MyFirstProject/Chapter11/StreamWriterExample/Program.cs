using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterExample
{
    class Program
    {
        // Example 11-21. Creating a StreamWriter
        // Example 11-22. Writing a string with StreamWriter
        // (11-22 is an evolution of 11-21 - it just adds the call to writer.Write.)
        private static void CreateFile(string fullPath, string p)
        {
            using (StreamWriter writer = File.CreateText(fullPath))
            {
                // Use the stream writer here

                writer.Write(p);
            }
        }
        static void Main(string[] args)
        {
            CreateFile("Test.txt", "Contents");
        }
    }

}
