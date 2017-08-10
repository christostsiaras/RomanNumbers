using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRomanNumbers
{
    [TestClass]
    public class TestConverter
    {
        [TestMethod]
        public void TestArabic2Roman()
        {
            Assert.AreEqual(Converter.Arabic2Roman(1), 1);
        }
    }
}
