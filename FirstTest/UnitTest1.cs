using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Jaffa")]
        public void TestMethod1()
        {
            Console.WriteLine("Hello");
        }
    }
}
