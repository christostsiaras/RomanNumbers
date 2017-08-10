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

            String test = "1,10,5000,-1";
            Console.WriteLine(test);
            Console.WriteLine(Scanner.ReplaceNumbers(test).ToString());

            Result result = Scanner.ReplaceNumbers(test);
            Console.WriteLine(result.Text.Equals("I,X ,5000,-I"));

            Console.ReadLine();

        }
    }
}
