using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikBilgiler
{
    public class Program
    {
        
       
        public string Nesne1(string takmaAd)
        {
            Akademisyenler a = new Akademisyenler();
            a.nickName = "rdas";
            _ = a.nickName;
            a.userName = "Resul";
            a.userSurname = "Daş";
            a.password = "785123";
            a.unvan = "Prof.Dr.";
            a.mail = "resuldas@gmail.com";
            a.Bilgi();
            return a.nickName;
       
        }
        public string Nesne2(string takmaAd)
        {
            Akademisyenler a = new Akademisyenler();
            a.nickName = "mbaykara";
            takmaAd = a.nickName;
            a.userName = "Muhammet";
            a.userSurname = "Baykara";
            a.password = "457856";
            a.unvan = "Dr.Öğr.Üyesi";
            a.mail = "muhammetbaykara23@gmail.com";
            a.Bilgi();
            return a.nickName;
        }
        public string Nesne3(string takmaAd)
        {
            Akademisyenler a = new Akademisyenler();
            a.nickName = "tbalakus";
            a.userName = "Talha Burak";
            a.userSurname = "Alakuş";
            a.password = "123456";
            a.unvan = "Arş.Gör.";
            a.mail = "burak.alakuss@gmail.com";
            a.Bilgi();
            return a.nickName;
        }
        public string Nesne4(string takmaAd)
        {
            string isim = "bpolat";
            Akademisyenler a = new Akademisyenler();
            a.nickName = "bpolat";
            a.userName = "Berna";
            a.userSurname = "Polat";
            a.password = "123456";
            a.unvan = "Arş.Gör.";
            a.mail = "brnpolatt@gmail.com";
            a.Bilgi();
            return a.nickName;
        }

        static void Main(string[] args)
        {
            Akademisyenler a = new Akademisyenler();
            a.nickName = "rdas";
            a.userName = "Resul";
            a.userSurname = "Daş";
            a.password = "785123";
            a.unvan = "Prof.Dr.";
            a.mail = "resuldas@gmail.com";
            a.Bilgi();
        }
    }

    public class Akademisyenler
    {
        public string nickName;
        public string userName;
        public string userSurname;
        public string password;
        public string mail;
        public string unvan;

        public void Bilgi()
        {
            Console.WriteLine("Kullanıcı Adı:{0}", nickName);
            Console.WriteLine("Şifre:{0}", password);
            Console.WriteLine("Kullanıcı Adı ve Soyadı: {0} ", userName+userSurname);
            Console.WriteLine("Ünvanı:{0}", unvan);
            Console.WriteLine("Mail Adresi: {0}", mail);
        }
    }
}
