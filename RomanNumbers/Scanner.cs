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
        //The regular expression to isolate integers
        private static readonly Regex regex = new Regex(@"\b[0-9]+\b");

        /// <summary>
        /// Scans a string for Arabic numbers and return the string with the numbers replaced in Roman
        /// as well as the total number of numbers replaced.
        /// <param name="input">The text with the Arabic number value to convert</param> 
        /// </summary>
        public static Result ReplaceNumbers(String input)
        {
            String output = input;
            //get the collection of matches
            MatchCollection matches = regex.Matches(input);
            //create an array of matches that will fit all matches
            Match[] matchesArray = new Match[matches.Count];
            //add all matches into the array of matches
            int counter = 0;
            foreach (Match match in regex.Matches(input))
            {
                matchesArray[counter++] = match;
            }

            /*replace first the last match to avoid changing input's string length that will
            break the string when replacing matches.*/
            for (int i=matchesArray.Length-1; i>=0 ;--i)
            {
                Match match = matchesArray[i];

                StringBuilder builder = new StringBuilder(output);
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, Converter.Arabic2Roman(Int32.Parse(match.ToString())));
                output = builder.ToString();
                output =output.Replace(match.ToString(),Converter.Arabic2Roman(Int32.Parse(match.ToString())));
            }
            //Result result = new Result();
            Result result = new Result() ;
            result.Text = output;
            result.Results=matchesArray.Length;
            return result;
        }
    }
}
