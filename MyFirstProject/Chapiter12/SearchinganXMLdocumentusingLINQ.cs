using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapiter12
{
    class SearchinganXMLdocumentusingLINQ
    {
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
        }
        public class Tester
        {
            private static XDocument CreateCustomerListXml()
            {
                List<Customer> customers = CreateCustomerList();
                var customerXml = new XDocument(new XElement("Customers",
                from customer in customers
                select new XElement("Customer",
                new XAttribute("FirstName", customer.FirstName),
                new XAttribute("LastName", customer.LastName),
                new XElement("EmailAddress", customer.EmailAddress)
                )));
                return customerXml;
            }

            private static List<Customer> CreateCustomerList()
            {
                List<Customer> customers = new List<Customer>
            {
                new Customer {FirstName = "Douglas",
                                LastName = "Adams",
                                EmailAddress = "dAdams@foo.com"},
                new Customer {FirstName = "Richard",
                                LastName = "Dawkins",
                                EmailAddress = "rDawkins@foo.com"},
                new Customer {FirstName = "Kenji",
                                LastName = "Yoshino",
                                EmailAddress = "kYoshino@foo.com"},
                new Customer {FirstName = "Ian",
                                LastName = "McEwan",
                                EmailAddress = "iMcEwan@foo.com"},
                new Customer {FirstName = "Neal",
                                LastName = "Stephenson",
                                EmailAddress = "nStephenson@foo.com"},
                new Customer {FirstName = "Randy",
                                LastName = "Shilts",
                                EmailAddress = "rShilts@foo.com"},
                new Customer {FirstName = "Michelangelo",
                                LastName = "Signorile ",
                                EmailAddress = "mSignorile@foo.com"},
                new Customer {FirstName = "Larry",
                                LastName = "Kramer",
                                EmailAddress = "lKramer@foo.com"},
                new Customer {FirstName = "Jennifer",
                                LastName = "Baumgardner",
                                EmailAddress = "jBaumgardner@foo.com"}
            };
                return customers;
            }

            static void Main()
            {
                XDocument customerXml = CreateCustomerListXml();

                Console.WriteLine("Search for single element...");
                var query =
                  from customer in
                      customerXml.Element("Customers").Elements("Customer")
                  where customer.Attribute("FirstName").Value == "Douglas"
                  select customer;
                XElement oneCustomer = query.SingleOrDefault();

                if (oneCustomer != null)
                {
                    Console.WriteLine(oneCustomer);
                }
                else
                {
                    Console.WriteLine("Not found");
                }


                Console.WriteLine("\nSearch using descendant axis... ");
                query = from customer in customerXml.Descendants("Customer")
                        where customer.Attribute("FirstName").Value == "Douglas"
                        select customer;
                oneCustomer = query.SingleOrDefault();
                if (oneCustomer != null)
                {
                    Console.WriteLine(oneCustomer);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

                Console.WriteLine("\nSearch using element values... ");
                query = from emailAddress in
                            customerXml.Descendants("EmailAddress")
                        where emailAddress.Value == "dAdams@foo.com"
                        select emailAddress;
                XElement oneEmail = query.SingleOrDefault();
                if (oneEmail != null)
                {
                    Console.WriteLine(oneEmail);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

                Console.WriteLine("\nSearch using child element values... ");
                query = from customer in customerXml.Descendants("Customer")
                        where customer.Element("EmailAddress").Value
                        == "dAdams@foo.com"
                        select customer;
                oneCustomer = query.SingleOrDefault();
                if (oneCustomer != null)
                {
                    Console.WriteLine(oneCustomer);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }       // end main
        }           // end class

    }
}
