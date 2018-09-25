using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void Iterator();

        static void Main(string[] args)
        {
            string results = " ";
            string[] separators = { " " };
            string value = "The handsome, energetic, young dog was playing with his smaller, more lethargic litter mate.";
            //string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] words = value.Split(separators, StringSplitOptions.None);
            for(int i=words.Length -1; i>=0; i = i-1)
            {
                results = results + words[i]+" ";
            }
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }   
}
