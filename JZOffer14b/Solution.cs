using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer14b
{
    class Solution
    {
        public int cuttingRope(int n)
        {
            //m、n都是整数，n > 1并且m > 1
            if (n <= 3)
            {
                return n - 1;
            }
            long res = 1;
            while (n > 4)
            {
                res = res * 3 % 1000000007;
                n = n - 3;
            }
            return (int)(res * n % 1000000007);
        }

    }
}
