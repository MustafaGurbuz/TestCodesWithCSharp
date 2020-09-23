using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace RecursivePowPerformansTesti
{
    class Program
    {
        public static int us(int tb,int usdeger)
        {
            if (usdeger == 0)
                return 1;
            else
                return tb * us(tb, usdeger - 1);
        }
        static void Main(string[] args)
        {
            Stopwatch sp = new Stopwatch();
            sp.Start();
            int a = us(5, 10);
            Console.WriteLine(a);
            sp.Stop();
            Console.WriteLine("Recursive ile üs alma süresi : " + sp.Elapsed);
            sp.Start();
            double b = Math.Pow(5, 10);
            Console.WriteLine(b);
            sp.Stop();
            Console.WriteLine("Pow fonksiyonu ile üs alma süresi : " + sp.Elapsed);
        }
    }
}
