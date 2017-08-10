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
    /// as well as the total number of numbers replaced. Numbers out of limmits and mathematical 
    /// symbols such as minus will be ignored.
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
            break the string when replacing matches.
            Non expected values e.g., numbers out of limmits will be ignored and not converted
            as well as will not be counted.
            Finally some addtional spaced might occure in case of replacing some numbers e.g., 10 with X.*/
            int invalidCounter = 0;
            for (int i=matchesArray.Length-1; i>=0 ;--i)
            {
                Match match = matchesArray[i];

                if (Converter.isValidEntry(Int32.Parse(match.ToString())))
                {
                    StringBuilder builder = new StringBuilder(output);
                    builder.Remove(match.Index, match.Length);
                    builder.Insert(match.Index, Converter.Arabic2Roman(Int32.Parse(match.ToString())));
                    output = builder.ToString();
                    String newString = Converter.Arabic2Roman(Int32.Parse(match.ToString()));
                    output = output.Replace(match.ToString(), newString);
                }
                else
                {
                    invalidCounter++;
                }
            }
            //Result result = new Result();
            Result result = new Result() ;
            result.Text = output;
            result.Results=matchesArray.Length-invalidCounter;
            return result;
        }
    }
}
