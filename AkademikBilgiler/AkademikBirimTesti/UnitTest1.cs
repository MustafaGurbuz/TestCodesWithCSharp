using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AkademikBilgiler;

namespace AkademikBirimTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NesneTestBir()
        {
            Program p = new Program();
            string deger = p.Nesne1("");
            Assert.AreEqual(deger,"rdas");
        }
        [TestMethod]
        public void NesneTestIki()
        {
            Program p = new Program();
            string deger = p.Nesne2("");
            Assert.AreEqual(deger, "mbaykaraa");
        }
        [TestMethod]
        public void NesneTestUc()
        {
            Program p = new Program();
            string deger = p.Nesne3("");
            Assert.AreEqual(deger, "tbalakus");
        }
        [TestMethod]
        public void NesneTestDort()
        {
            Program p = new Program();
            string deger = p.Nesne4("");
            Assert.AreEqual(deger, "bpolattt");
        }
    }
}
