using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlfabePerformansTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = new char[26];
            int sira = 0;

            Console.WriteLine("Bir harf giriniz:");
            char a = Console.ReadKey().KeyChar;

            for (char i = 'a'; i <= 'z'; i++)

            {
                alfabe[sira] = i; // "alfabe" dizisinin ""...ıncı sıra"sındaki harf(değer) i dir.

                Console.Write(alfabe[sira]);
                
            }
            if (a == alfabe[sira])
            {
                Console.WriteLine(sira);
            }
            else
            {
                Console.WriteLine("Değer yanlıştır.");
            }
        }
    }
}
