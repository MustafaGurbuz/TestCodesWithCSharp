using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiBilgileri
{
    public class Personal
    {
        public string BilgiGetir(string isim, string soyisim)
        {
            return string.Concat(isim, "", soyisim);
        }
        static void Main(string[] args)
        {
        }
    }
}
