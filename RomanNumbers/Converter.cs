using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    static class Converter
    {
        //The dictionary storing values to translate Arabic numbers to Roman Numbers
        private static Dictionary<int, String> romanNumbers = null;
        private static readonly int minValue = 1;
        private static readonly int maxValue = 3999;
        private static int itteration = 0;//the number that the recursive algorithm has been executed

        /// <summary>
        /// The translator get as input a positive integer up to 3999 and returns the Roman value.
        /// </summary>
        private static void init()
        {
            romanNumbers.Add(1, "I");
            romanNumbers.Add(4, "IV");
            romanNumbers.Add(5, "V");
            romanNumbers.Add(9, "IX");
            romanNumbers.Add(10, "X");
            romanNumbers.Add(40, "XL");
            romanNumbers.Add(50, "L");
            romanNumbers.Add(90, "XC");
            romanNumbers.Add(100, "C");
            romanNumbers.Add(400, "CD");
            romanNumbers.Add(500, "D");
            romanNumbers.Add(900, "CM");
            romanNumbers.Add(1000, "M");
        }

        /// <summary>
        /// The method converts an Arabic number to Roman.
        /// <param name="value">The Arabic number value to convert</param> 
        /// </summary>
        public static String Arabic2Roman(int value)
        {
            //Check if the init method has been already trigerred.
            Console.WriteLine(itteration);
            if (itteration==0)
            {
                romanNumbers= new Dictionary<int, String>();
                init();
            }
            itteration++;

            if (value >= minValue && value <= maxValue)
            {
                int flooredKeyValue = romanNumbers.Keys.Where<int>(key => key <= value).ToArray<int>().Max();

                //Use recursion to calculate the Roman number
                if (value == flooredKeyValue)
                {
                    if (value.ToString().Length==1)//if this is the last itteration
                    {
                        itteration = 0;
                    }
                    return romanNumbers[value];
                }

                return romanNumbers[flooredKeyValue] + Arabic2Roman(value - flooredKeyValue);
            }
            return null;//return null if the value is greater than 3000 or less than 0
        }
    }
}
