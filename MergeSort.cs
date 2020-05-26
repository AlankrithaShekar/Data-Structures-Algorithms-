using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MergeSort : Program
    {
        public static void MergeSortImplementation(int[] a)
        {
            int low = 0, high = a.Length - 1;
            Mergesort(low, high, a);
        }
        public static void Mergesort(int low, int high, int[] a)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                Mergesort(low, mid, a);
                Mergesort(mid + 1, high,a);
                Merged(low, mid, high,a);
            }
           
        }
        public static void Merged(int low, int mid, int high, int[] a)
        {
            int i, j, k;
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] left = new int[n1];
            int[] right = new int[n2];

            Console.WriteLine("{0},{1}", low, mid);
            for (i = 0; i < n1; i++)
                left[i] = a[low+i];
            for (j = 0; j < n2; j++)
                right[j] = a[mid + j + 1];
            i = 0; j = 0;k = low;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    a[k] = left[i];
                    i++;
                }
                else
                {
                    a[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                a[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                a[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
