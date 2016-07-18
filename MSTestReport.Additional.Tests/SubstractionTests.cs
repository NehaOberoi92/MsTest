using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestReport.Additional.Tests
{
    [TestClass]
    public class SubstractionTests
    {
        [TestMethod]
        public void TwoMinusTwoReturnsZero()
        {
            Calculator obj = new Calculator();
            int a = 2;
            int b = 2;
            int result = obj.substract(a, b);
            Assert.AreEqual(result, 0);
        }
    }
}
