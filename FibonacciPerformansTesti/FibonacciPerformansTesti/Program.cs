using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FibonacciPerformansTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b = 1,t;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0;i < 10; i++)
            {
                t = a + b;
                Console.Write(t+" ");
                a = b;
                b = t;
            }
            sw.Stop();
            Console.WriteLine("");
            Console.WriteLine("for ile geçen süre : " + sw.Elapsed);

            int j = 0;
            int c = 0, d = 1, tt;
            sw.Start();
            while (j < 10)
            {
                tt = c + d;
                Console.Write(tt + " ");
                c = d;
                d = tt;
                j++;
            }
            sw.Stop();
            Console.WriteLine("");
            Console.WriteLine("while ile geçen süre : " + sw.Elapsed);

            int k = 0;
            int m = 0, n = 1, ttt;
            sw.Start();
            do
            {
                ttt = m + n;
                Console.Write(ttt + " ");
                m = n;
                n = ttt;
                k++;
            } while (k < 10);
            sw.Stop();
            Console.WriteLine("");
            Console.WriteLine("do-while ile geçen süre : " + sw.Elapsed);
        }
    }
}
