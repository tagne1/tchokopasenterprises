using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter_Listing_2_17
{
    public partial class ConnStringRetrival : System.Web.UI.Page
    {
        static void Main()
        {
            GetConnectionStrings();
            Console.ReadLine();
        }

        static void GetConnectionStrings()

        {
            var connectionString = ConfigurationManager.ConnectionStrings["NorthwindEntities"].ConnectionString;
            Console.WriteLine("connectionString =", connectionString);
            /*
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    Console.WriteLine(cs.Name);
                    Console.WriteLine(cs.ProviderName);
                    Console.WriteLine(cs.ConnectionString);
                }
            }
            */
        }


    }
}