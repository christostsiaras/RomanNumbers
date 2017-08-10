using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    class Converter
    {
        //The dictionary storing values to translate Arabic numbers to Roman Numbers
        private Dictionary<int, String> romanNumbers = new Dictionary<int, String>();
        private readonly int minValue = 1;
        private readonly int maxValue = 3999;

        /// <summary>
        /// The translator get as input a positive integer up to 3999 and returns the Roman value.
        /// </summary>
        public Converter()
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
        public String Arabic2Roman(int value)
        {
            if (value >= minValue && value <= maxValue)
            {
                int flooredKeyValue = romanNumbers.Keys.Where<int>(key => key <= value).ToArray<int>().Max();

                //Use recursion to calculate the Roman number
                if (value == flooredKeyValue)
                {
                    return romanNumbers[value];
                }

                //if more than one digit in the Arabic number then add space between Roman "digits"
                String space = "";
                if (value.ToString().Length > 1)
                {
                    space = " ";
                }

                return romanNumbers[flooredKeyValue] +space+ Arabic2Roman(value - flooredKeyValue);
            }
            return null;//return null if the value is greater than 3000 or less than 0
        }
    }
}
