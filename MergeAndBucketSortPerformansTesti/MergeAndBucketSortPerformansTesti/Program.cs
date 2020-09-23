using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MergeAndBucketSortPerformansTesti
{
    class Program
    {
        public static void BucketSort(ref int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
           
            Random random = new Random();
            //Bucket Sort Algoritması
            int[] data = new int[10];
            st.Start();
            for(int j = 0; j < 10; j++)
            {
                data[j] = random.Next(0, 100);
            }
            BucketSort(ref data);
            for (int j = 0; j < 10; j++)
            {
                Console.Write(data[j] + " ");
            }
            st.Stop();
            Console.WriteLine("");
            Console.WriteLine("Bucket Sort sıralama ile geçen süre : " + st.Elapsed);

            //Merge Sort Algoritması
            List<int> unsorted = new List<int>();
            List<int> sorted;

            st.Start();
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
            }
            Console.WriteLine();

            sorted = MergeSort(unsorted);
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            st.Stop();
            Console.WriteLine("Merge Sort sıralama ile geçen süre : " + st.Elapsed);
        }


        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
