using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    public class DortIslem
    {
        public double Topla(double num1, double num2, double num3, double num4)
        {
            return num1 + num2 + num3 + num4;
        }
        public double Cikar(double num1, double num2, double num3, double num4)
        {
            return num1 - num2 - num3 - num4;
        }
        public double Carp(double num1, double num2, double num3, double num4)
        {
            return num1 * num2 * num3 * num4;
        }
        public double Bolme(double num1, double num2, double num3, double num4)
        {
            return num1 / num2 / num3 / num4;
        }
        static void Main(string[] args)
        {
        }
    }
}
