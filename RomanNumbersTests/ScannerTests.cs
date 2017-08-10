using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class ScannerTests
    {
        [TestMethod()]
        public void ReplaceNumbersTest()
        {
            String test = "1,10,5000,-1";
            Result result=Scanner.ReplaceNumbers(test);
            Assert.IsTrue(result.Results==3);
            Assert.IsTrue(result.Text.Equals("I,X ,5000,-I"));
        }
    }
}