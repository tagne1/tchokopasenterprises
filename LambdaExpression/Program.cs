using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {

        private static int[] GetArray(int n, int lower, int upper)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int ctr = 1; ctr <= n; ctr++)
                list.Add(rnd.Next(lower, upper + 1));

            return list.ToArray();
        }

        static void Main(string[] args)
        {
            
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach ( var n in evenNumbers)
            {
                Console.WriteLine(n);
                Console.WriteLine();
            }
            Console.ReadLine();
           

            List<char> chrlist = new List<char>() { 'a', 'b', 'a', 'b', 'c', 'a', 'd', 'e'};
            var duplicateKeys = chrlist.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);

            foreach(var chr in duplicateKeys)
            {
                Console.WriteLine(chr);
                Console.WriteLine();
            }
            Console.ReadLine();

            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);
            Console.ReadLine();
            // Outputs: 4 scores are greater than 80    


            // Get an array of n random integers.
            int[] values = GetArray(50, 0, 1000);
            int lBound = 300;
            int uBound = 600;
            int[] matchedItems = Array.FindAll(values, x =>
                                             x >= lBound && x <= uBound);
            for (int ctr = 0; ctr < matchedItems.Length; ctr++)
            {
                Console.Write("{0}  ", matchedItems[ctr]);
                if ((ctr + 1) % 12 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


