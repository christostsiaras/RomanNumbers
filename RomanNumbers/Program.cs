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
            //Converter converter = new Converter();
            int testValue = 888;
            //int failValue = 0;
            int failValue = 4000;
            Console.WriteLine(Converter.Arabic2Roman(testValue));
            Console.WriteLine(Converter.Arabic2Roman(failValue));
            Console.ReadLine();
        }
    }
}
