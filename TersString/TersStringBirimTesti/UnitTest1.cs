using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TersString;

namespace TersStringBirimTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TersStringTest()
        {
            Program p = new Program();
            string kelime = "Mustafa";
            string beklenen = "afatsuM";
            string real = p.KelimeTers(kelime);
            Assert.AreEqual(beklenen, real);
        }
        public void TestMethod1()
        {
        }
    }
}
