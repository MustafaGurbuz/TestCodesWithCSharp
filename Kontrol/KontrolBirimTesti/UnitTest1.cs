using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kontrol;

namespace KontrolBirimTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KontrolTesti()
        {
            Program p = new Program();
            int b = 4;
            bool real = p.Check(b);
            Assert.IsTrue(real);
        }
        public void TestMethod1()
        {
        }
    }
}
