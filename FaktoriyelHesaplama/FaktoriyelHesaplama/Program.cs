using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplama
{
    public class Program
    {
        public int Fakt(int deger)
        {
            int sonuc = 1;
            for(int i = 1;i<=deger;i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
        }
    }
}
