using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    class Converter
    {
        private Dictionary<int, String> romanNumbers = new Dictionary<int, String>();
        private readonly int minValue = 1;
        private readonly int maxValue = 3999;

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

        public String Arabic2Roman(int value)
        {
            if (value >= minValue && value <= maxValue)
            {
                int[] keys = romanNumbers.Keys.ToArray<int>();
                int flooredKeyValue = 0;
                foreach (int key in keys)
                {
                    if (key <= value)
                    {
                        flooredKeyValue = key;
                    }
                    else
                    {
                        break;
                    }
                }

                //Use recursion to calculate the Roman number
                if (value == flooredKeyValue)
                {
                    return romanNumbers[value];
                }
                return romanNumbers[flooredKeyValue] + Arabic2Roman(value - flooredKeyValue);
            }
            return null;
        }
    }
}
