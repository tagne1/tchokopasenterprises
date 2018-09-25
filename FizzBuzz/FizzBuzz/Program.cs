using System;
using System.Collections.Generic;

/*
*******************    “FizzBuzz games”  *****************************************************************************
Print number starting from 1 to 100. When a number is multiple of three, print “Fizz” instead of a number on the console 
and if multiple of five then print “Buzz” on the console. For numbers which are multiple of three as well five, 
print “FizzBuzz” on the console. The function you define will return an array of string. Print your result on the screen.
***********************************************************************************************************************
*/

namespace FizzBuzz
{
    class Program
    {
        public static string[] FizzBuzz(int n)
        {
        List<string> listString = new List<string>();
        string a = "FizzBuzz";
        string b = "Fizz";
        string c = "Buzz";
        
            for (int i = 0; i < n; i++)
            {

                if (n % 3 == 0 && n % 5 == 0)
                {
                    listString.Add(a);
                    //Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    listString.Add(b);
                    //Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    listString.Add(c);
                    //Console.WriteLine("Buzz");
                }
                else
                {
                    listString.Add(Convert.ToString(n));
                    //Console.WriteLine(n);
                }
            }
            return listString.ToArray();
        }
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number between 1 and 100");
            Console.WriteLine();
            int nber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered is: {0}", nber);
            Console.WriteLine();

            Console.WriteLine("See results below:");
            Console.WriteLine();
            foreach (string str in FizzBuzz(nber))
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Exit!");
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
