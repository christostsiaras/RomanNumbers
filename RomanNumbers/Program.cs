using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int testValue = 1;
            int failValue = -10;
            //int failValue = 4000;
            Console.WriteLine(Converter.Arabic2Roman(testValue));
            Console.WriteLine(Converter.Arabic2Roman(failValue));

            string test = "Eleven 11 and hundret eleven 111.";
            Console.WriteLine(test);
            Console.WriteLine(Scanner.ReplaceNumbers(test));

            Console.ReadLine();


        }
    }
}
