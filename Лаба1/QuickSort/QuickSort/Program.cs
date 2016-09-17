using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public static void QuicksortGeneric<T>(T[] elements, int left, int right) where T : IComparable
        {
            int i = left, j = right;
            T pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuicksortGeneric(elements, left, j);
            }

            if (i < right)
            {
                QuicksortGeneric(elements, i, right);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort quickSort = new QuickSort();
            Random rand = new Random();
            int[] a = new int[1000];
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(-50000,50000);
            
            foreach (var temp in a)
            {
                Console.Write("{0} ",temp);
            }
            Console.ReadKey();
        }
    }
}
