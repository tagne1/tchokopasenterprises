using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 11-6. Setting the current directory
            Directory.SetCurrentDirectory(@"c:\");

            foreach (var user in Directory.GetDirectories("Users"))
            {
                Console.WriteLine(user);
            }
        }
    }

}
