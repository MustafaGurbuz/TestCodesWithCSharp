using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KitapAndISBNPerformansTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sy = new Stopwatch();
            Dictionary<string, string> kitap = new Dictionary<string, string>();
            kitap.Add("Yüzük Kardeşliği", "9789753425");
            kitap.Add("İki Kule", "9753421818");
            kitap.Add("Kralın Dönüşü", "9753422024");
            kitap.Add("Dune", "605375479X");
            kitap.Add("Dune Çocukları", "6053756024");
            kitap.Add("Drizzt Efsanesi 1 Anayurt", "6053755575");
            kitap.Add("Zaman Çarkı 1 Dünyanın Gözü", "9758725718");
            kitap.Add("Zaman Çarkı 2 Büyük Av", "9758725726");

            Console.Write("Kitap Adı Giriniz:");
            string k = Console.ReadLine();
            string number=" ";
            sy.Start();
            if (kitap.TryGetValue(k,out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Değer Bulunamadi");
            }
            sy.Stop();
            Console.WriteLine("if-else ile geçen süre: "+sy.Elapsed);

            sy.Start();
            switch(k)
            {
                case "Dune":
                    Console.WriteLine(kitap.ContainsValue("605375479X"));
                    break;
                case "İki Kule":
                    Console.WriteLine(kitap.ContainsValue("9753421818"));
                    break;
                case "Yüzük Kardeşliği":
                    Console.WriteLine(kitap.ContainsValue("9789753425"));
                    break;
                case "Dune Çocukları":
                    Console.WriteLine(kitap.ContainsValue("6053756024"));
                    break;
                case "Zaman Çarkı 1 Dünyanın Gözü":
                   
                case "Zaman Çarkı 2 Büyük Av":
                    Console.WriteLine(kitap.ContainsValue("9758725726"));
                    break;
            }
            sy.Stop();
            Console.WriteLine("switch-case ile geçen süre: " + sy.Elapsed);
        }
    }
}
