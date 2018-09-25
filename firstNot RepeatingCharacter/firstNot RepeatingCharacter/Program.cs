using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNot_RepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstNotRepeatingCharacter(string s)
            {
                var chars = s.ToCharArray();
             
                for (int i = 0; i < s.Length; i++) {
                     char firstChar = chars[i];
                     var count = s.Where(item => item == firstChar).Count();
                     if (count == 1) {
                         return firstChar;
                     }
                 }

                return '_';
            }
            var t = "abacabad";
            
            Console.WriteLine(firstNotRepeatingCharacter(t));
            Console.ReadLine();
        }
    }
}
