using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    /// <summary>
    /// Stores the result of the scanner replace number method.
    /// </summary>
    public class Result
    {
        private string text="";  // the text field
        private int results=0;  // the results field
        public string Text    // the Text property
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public int Results    // the Results property
        {
            get
            {
                return results;
            }
            set
            {
                results = value;
            }
        }

        /// <summary>
        /// Prints the result of the Scanner replace number method.
        /// </summary>
        public String ToString()
        {
            return Text + "\n" + Results + " integers have been replaced.";
        }

    }
}
