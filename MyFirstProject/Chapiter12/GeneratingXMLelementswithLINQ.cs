using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapiter12
{
    class GeneratingXMLelementswithLINQ
    {
        // Simple customer class
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
        }
        // Main program
        public class Tester
        {
            static void Main()
            {
                List<Customer> customers = CreateCustomerList();

                // Example 12-5. Generating XML elements with LINQ
                var customerXml = new XDocument(new XElement("Customers",
                    from customer in customers
                    select new XElement("Customer",
                        new XAttribute("FirstName", customer.FirstName),
                        new XAttribute("LastName", customer.LastName),
                        new XElement("EmailAddress", customer.EmailAddress)
                        )));

                Console.WriteLine(customerXml.ToString());
                Console.Read();
            }

            // Create a customer list with sample data
            private static List<Customer> CreateCustomerList()
            {
                List<Customer> customers = new List<Customer>
            {
                new Customer { FirstName = "Orlando",
                               LastName = "Gee",
                               EmailAddress = "orlando0@hotmail.com"},
                new Customer { FirstName = "Keith",
                               LastName = "Harris",
                               EmailAddress = "keith0@hotmail.com" },
                new Customer { FirstName = "Donna",
                               LastName = "Carreras",
                               EmailAddress = "donna0@hotmail.com" },
                new Customer { FirstName = "Janet",
                               LastName = "Gates",
                               EmailAddress = "janet1@hotmail.com" },
                new Customer { FirstName = "Lucy",
                               LastName = "Harrington",
                               EmailAddress = "lucy0@hotmail.com" }
            };
                return customers;
            }
        }

    }
}
