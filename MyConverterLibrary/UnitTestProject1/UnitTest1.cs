using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new ConsoleApp1.Class1();
            var res = calc.GetInt("42");
            Assert.AreEqual(42, res);
        }
    }
}
