using System;

namespace CodeFight_Test
{
    class Program
    {
        public static double ArrayMedianTest(int[] X)
        {
            Array.Sort(X);
            int arrayLength = X.Length;
            int middleNumber = arrayLength / 2;
            double medianOfArray = 0;
            double a = X[middleNumber - 1];
            double b = X[middleNumber];

            if (arrayLength % 2 == 0)
            {
                medianOfArray = (a + b) / 2;
            }
            else
            {
                medianOfArray = X[middleNumber];
            }

            return medianOfArray;
        }

        static void Main(string[] args)
        {          
            int[] input1 = { 0, 2, 5, 3, 9, 15, 12 };

            Console.WriteLine("The result of the odd array of integer with length of {0} is below:", input1.Length);

            Console.WriteLine(ArrayMedianTest(input1));

            Console.WriteLine("Press Any Key to Continue"); 

            Console.ReadLine();

            int[] input2 = { 0, 2, 5, 3, 9, 15, 12, 18 };

            Console.WriteLine("The result of the even array of integer with length of {0} is below:", input2.Length);

            Console.WriteLine(ArrayMedianTest(input2));

            Console.WriteLine("Press Any Key to Exit!");

            Console.ReadLine();
        }
    }
}
