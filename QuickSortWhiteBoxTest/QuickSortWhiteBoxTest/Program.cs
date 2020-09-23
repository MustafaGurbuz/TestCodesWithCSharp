using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortWhiteBoxTest
{
    class Program
    {
        private static void QuickSort(int[] dizi, int sol, int sag)
        {
            if (sol < sag)
            {
                int pivot = Partition(dizi, sol, sag);

                if (pivot > 1)
                {
                    QuickSort(dizi, sol, pivot - 1);
                }
                if (pivot + 1 < sag)
                {
                    QuickSort(dizi, pivot + 1, sag);
                }
            }

        }

        private static int Partition(int[] dizi, int sol, int sag)
        {
            int pivot = dizi[sol];
            while (true)
            {

                while (dizi[sol] < pivot)
                {
                    sol++;
                }

                while (dizi[sag] > pivot)
                {
                    sag--;
                }

                if (sol < sag)
                {
                    if (dizi[sol] == dizi[sag]) return sag;

                    int temp = dizi[sol];
                    dizi[sol] = dizi[sag];
                    dizi[sag] = temp;


                }
                else
                {
                    return sag;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i + 1 + ".sayi : ");
                dizi[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Normal dizi : ");
            foreach (var item in dizi)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QuickSort(dizi, 0, dizi.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sıralanmış dizi : ");

            foreach (var item in dizi)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
