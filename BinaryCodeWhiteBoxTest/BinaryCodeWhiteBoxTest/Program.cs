using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCodeWhiteBoxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kalan;
            string binary = "";
            Console.Write("Sayıyı Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi != 0)
            {
                kalan = sayi % 2;
                sayi = sayi / 2;

                binary = kalan.ToString() + binary;
            }
            Console.WriteLine("2'lik Sistemde Karşılığı : {0}", binary);

            Console.ReadKey();
        }
    }
}
