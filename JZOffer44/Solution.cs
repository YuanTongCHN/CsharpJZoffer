using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer44
{
    public class Solution
    {
        public int FindNthDigit(int n)
        {
            if (n < 0) return -1;
            int digit = 1;
            long count = 9;
            long start = 1;
            long nTmp = n;
            while (nTmp > count)
            {
                nTmp -= count;
                digit += 1;
                start *= 10;
                count = 9 * digit * start;
            }
            int num = (int)(start + (nTmp - 1) / digit);
            int index = (int)((nTmp - 1) % digit);
            string str = num.ToString();
            string resultString = str[index].ToString();
            int result = Convert.ToInt32(resultString);
            return result;
        }
    }
}
