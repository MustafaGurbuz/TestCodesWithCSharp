using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KisiBilgileri;

namespace KisiBilgileriBirimTesti
{
    [TestClass]
    public class PersonalBirimTesti
    {
        [TestMethod]

        public void TestBilgi()
        {
            Personal p = new Personal();
            string isim = "Mustafa";
            string soyIsim = "Gürbüz";
            string expactation = "Mustafa" + "Gürbüz";
            string real = p.BilgiGetir(isim, soyIsim);
            Assert.AreEqual(expactation, real);
        }
        public void TestMethod1()
        {
        }
    }
}
