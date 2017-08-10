using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    /// <summary>
    /// Converts an Arabic number to Roman.
    /// </summary>
    public static class Converter
    {
        //The dictionary storing values to translate Arabic numbers to Roman Numbers
        private static Dictionary<int, String> romanNumbers = null;
        private static readonly int minValue = 1;
        private static readonly int maxValue = 3999;

        /// <summary>
        /// Initializes the converter dictionary.
        /// </summary>
        private static void Initialize()
        {
            romanNumbers = new Dictionary<int, String>();
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
            if (value >= minValue && value <= maxValue)
            {
                Initialize();
                String output = "";
                //Split the number into thousants.  hundrets, etc
                int i = 10;
                while (value >= i / 10)
                {
                    output = (" " + Convert(value % i - value % (i / 10))) + output;
                    i *= 10;
                }
                //Remove the first space of the output if it is larger in length than 1
                if (output.Length>1)
                {
                    output = output.Substring(1);
                }
                return output;
            }
            return null;
        }

        /// <summary>
        /// The method converts an Arabic number to Roman.
        /// <param name="value">The Arabic number value to convert</param> 
        /// </summary>
        private static String Convert(int value)
        {
            if (value==0)
            {
                return "";
            }
            else
            {
                int flooredKeyValue = romanNumbers.Keys.Where<int>(key => key <= value).ToArray<int>().Max();

                //Use recursion to calculate the Roman number
                if (value == flooredKeyValue)
                {
                    return romanNumbers[value];
                }
                return romanNumbers[flooredKeyValue] + Convert(value - flooredKeyValue);
            }      
        }

    }
}
