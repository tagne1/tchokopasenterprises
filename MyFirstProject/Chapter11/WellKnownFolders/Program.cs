using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellKnownFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 11-13. Getting a well-known folder location
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Console.WriteLine(path);
        }
    }
}
