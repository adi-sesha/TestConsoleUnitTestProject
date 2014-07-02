using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;

namespace TestConsoleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {            
            TestConsole.MyTest tt = new TestConsole.MyTest();
            Assert.AreEqual("Hello", tt.getHello());
            
        }
    }
}
