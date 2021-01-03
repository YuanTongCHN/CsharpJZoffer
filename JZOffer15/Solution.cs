using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer15
{
    class Solution
    {
        public int HammingWeight(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }
    }
}
