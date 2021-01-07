using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer43
{
    public class Solution
    {
        public int CountDigitOne(int n)
        {
            int result = 0;
            int low = 0;
            int digit = 1;
            int high = n / 10;
            int cur = n % 10;
            while (high != 0 || cur != 0)
            {
                if (cur == 0)
                {
                    result += high * digit;
                }
                else if (cur == 1)
                {
                    result += high * digit + low + 1;
                }
                else
                {
                    result += (high + 1) * digit;
                }
                low = low + cur * digit;
                cur = high % 10;
                high = high / 10;
                digit *= 10;
            }
            return result;
        }
    }
}
