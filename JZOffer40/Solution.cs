using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer40
{
    public class Solution
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (arr.Length == 0) return new int[0];
            return Partition(arr, 0, arr.Length - 1, k);
        }
        public int[] Partition(int[] arr, int start, int end, int k)
        {
            int lf;
            int rf;
            if (start >= end)
            {
                int[] result = new int[k];
                Array.Copy(arr, 0, result, 0, k);
                return result;
            }
            while (true)
            {
                for (lf = start + 1; lf <= end; lf++)
                {
                    if (arr[lf] > arr[start])
                    {
                        break;
                    }
                }
                for (rf = end; rf >= start + 1; rf--)
                {
                    if (arr[rf] <= arr[start])
                    {
                        break;
                    }
                }
                if (lf < rf)
                {
                    Swap(arr, lf, rf);
                }
                else
                {
                    break;
                }
            }
            if (arr[rf] <= arr[start]) Swap(arr, start, rf);
            if (rf == k - 1)
            {
                int[] result = new int[k];
                Array.Copy(arr, 0, result, 0, k);
                return result;
            }
            else if (rf > k - 1) return Partition(arr, start, rf - 1, k);
            else return Partition(arr, rf + 1, end, k);

        }
        public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
