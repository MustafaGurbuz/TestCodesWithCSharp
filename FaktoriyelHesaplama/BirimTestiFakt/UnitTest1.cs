using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaktoriyelHesaplama;

namespace BirimTestiFakt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FaktTest()
        {
            Program p = new Program();
            int sonuc = p.Fakt(7);
            Assert.AreEqual(sonuc, 5040);
        }
        public void TestMethod1()
        {
        }
    }
}
