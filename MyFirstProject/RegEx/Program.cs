using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Regex.Match("cv15.doc", @"cv\d*\.doc").Success);
            Console.ReadKey();
            //Console.ReadLine();
        }
    }
}
