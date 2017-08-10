using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanNumbers
{
    /// <summary>
    /// Scans a string for Arabic numbers and return the string with the numbers replaced in Roman
    /// as well as the total number of numbers replaced.
    /// </summary>
    public static class Scanner
    {

        private static readonly Regex regex = new Regex(@"\b[0-9]+\b");

        public static String ReplaceNumbers(String input)
        {
            int counter = 0;
            String output = input;
            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match+" length:"+match.Length+" index:"+match.Index);

                StringBuilder builder = new StringBuilder(output);
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, Converter.Arabic2Roman(Int32.Parse(match.ToString())));
                output = builder.ToString();


                //output =output.Replace(match.ToString(),Converter.Arabic2Roman(Int32.Parse(match.ToString())));
                counter++;
            }
            return output + "\n"+counter.ToString()+" integers have been replaced.";
        }
    }
}
