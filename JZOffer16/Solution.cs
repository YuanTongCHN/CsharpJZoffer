using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer16
{
    class Solution
    {
        public double MyPow(double x, int n)
        {
            if (x == 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            long b = n;
            double res = 1.0;
            if (b < 0)
            {
                x = 1 / x;
                b = -b;
            }
            while (b > 0)
            {
                if ((b & 1) == 1)
                {
                    res *= x;
                }
                b = b >> 1;
                x *= x;
            }
            return res;
        }
    }
}
