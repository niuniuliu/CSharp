using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hello World!");
            Assert.AreEqual(1, 1);
        }
    }
}
