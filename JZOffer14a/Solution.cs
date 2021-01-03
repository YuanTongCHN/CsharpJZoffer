using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer14a
{
    public class Solution
    {
        public int CuttingRope(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            if (n == 3)
            {
                return 2;
            }
            int timesOf3 = n / 3;
            int lastOf3 = n % 3;
            if (lastOf3 == 0)
            {
                return (int)Math.Pow(3, timesOf3);
            }
            else if (lastOf3 == 1)
            {
                timesOf3 -= 1;
                return (int)Math.Pow(3, timesOf3) * 4;
            }
            else
            {
                return (int)Math.Pow(3, timesOf3) * 2;
            }
        }
    }
}
