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
    public class ConverterTests
    {
        [TestMethod()]
        public void Arabic2RomanTest()
        {
            Assert.AreEqual(Converter.Arabic2Roman(1).Replace(" ",String.Empty),"I");
            Assert.AreEqual(Converter.Arabic2Roman(4).Replace(" ", String.Empty), "IV");
            Assert.AreEqual(Converter.Arabic2Roman(5).Replace(" ", String.Empty), "V");
            Assert.AreEqual(Converter.Arabic2Roman(9).Replace(" ", String.Empty), "IX");
            Assert.AreEqual(Converter.Arabic2Roman(10).Replace(" ", String.Empty), "X");
            Assert.AreEqual(Converter.Arabic2Roman(40).Replace(" ", String.Empty), "XL");
            Assert.AreEqual(Converter.Arabic2Roman(50).Replace(" ", String.Empty), "L");
            Assert.AreEqual(Converter.Arabic2Roman(90).Replace(" ", String.Empty), "XC");
            Assert.AreEqual(Converter.Arabic2Roman(100).Replace(" ", String.Empty), "C");
            Assert.AreEqual(Converter.Arabic2Roman(400).Replace(" ", String.Empty), "CD");
            Assert.AreEqual(Converter.Arabic2Roman(500).Replace(" ", String.Empty), "D");
            Assert.AreEqual(Converter.Arabic2Roman(900).Replace(" ", String.Empty), "CM");
            Assert.AreEqual(Converter.Arabic2Roman(1000).Replace(" ", String.Empty), "M");

            Assert.AreEqual(Converter.Arabic2Roman(1981).Replace(" ", String.Empty), "MCMLXXXI");
            Assert.AreNotEqual(Converter.Arabic2Roman(1981), "MCMLXXXI");

            Assert.AreEqual(Converter.Arabic2Roman(3999).Replace(" ", String.Empty), "MMMCMXCIX");
            Assert.AreNotEqual(Converter.Arabic2Roman(3999), "MMMCMXCIX");

            Assert.IsNull(Converter.Arabic2Roman(0));
            Assert.IsNull(Converter.Arabic2Roman(-1));
            Assert.IsNull(Converter.Arabic2Roman(4000));
        }
    }
}