using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hesaplama;

namespace HesaplamaBirimTesti
{
    [TestClass]
    public class BirimTesti
    {
        [TestMethod]
        public void TestToplama()
        {
            DortIslem p = new DortIslem();
            double sonuc = p.Topla(10, 10, 10, 10);
            Assert.AreEqual(sonuc, 40);
        }
        [TestMethod]
        public void TestCikarma()
        {
            DortIslem p = new DortIslem();
            double sonuc = p.Cikar(24, 8, 7, 5);
            Assert.AreEqual(sonuc, 1);
        }
        [TestMethod]
        public void TestCarpma()
        {
            DortIslem p = new DortIslem();
            double sonuc = p.Carp(15, 12, 2, 5);
            Assert.AreEqual(sonuc, 1800);
        }
        [TestMethod]
        public void TestBolme()
        {
            DortIslem p = new DortIslem();
            double sonuc = p.Bolme(88, 11, 4, 2);
            Assert.AreEqual(sonuc, 5);
        }
        public void TestMethod1()
        {
        }
    }
}
