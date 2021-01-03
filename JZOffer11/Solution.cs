using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer11
{
    public class Solution
    {
        public int MinArray(int[] numbers)
        {
            int len = numbers.Length;
            if (len == 0)
            {
                return numbers[0];
            }
            int l = 0;
            int r = len - 1;
            while (l < r)
            {
                int mid = (l + r) >> 1;
                if (numbers[mid] > numbers[r])
                {
                    l = mid + 1;
                }
                else if (numbers[mid] < numbers[r])
                {
                    r = mid;
                }
                else
                {
                    r--;
                }
            }
            return numbers[l];
        }
    }
}
