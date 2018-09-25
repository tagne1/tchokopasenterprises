using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapiter12
{
    class LoadingXML
    {
        static void Main(string[] args)
        {
            // Example 12-2. Loading XML from a string
            XDocument doc = XDocument.Parse("<Customers><Customer /></Customers>");

            Console.WriteLine(doc);
        }

    }
}
