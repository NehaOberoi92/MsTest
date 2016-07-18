using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestReport.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void CanAdd()
        {
            int a = 2;
            int b = 2;
            Calculator obj = new Calculator();
            int result = obj.add(a, b);
            Assert.AreEqual(result, 4);
        }
    }
}
