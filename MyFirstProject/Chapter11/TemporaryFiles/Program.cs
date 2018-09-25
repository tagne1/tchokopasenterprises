using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 11-11. Deleting a file
            string fileName = Path.GetTempFileName();
            try
            {
                // Use the file
                // ...
                // Display the filename
                Console.WriteLine(fileName);
                // And wait for some input
                Console.ReadKey();
            }
            finally
            {
                // Then clean it up
                File.Delete(fileName);
            }

            // Example 11-12. Showing a random filename
            Console.WriteLine(Path.GetRandomFileName());
        }
    }


}
