using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer10a
{
    public class Solution
    {
        public int Fib(int n)
        {
            if (n == 1) return 1;
            if (n < 1) return 0;
            int fib1 = 0;
            int fib2 = 1;
            int fibN = 0;
            for (int i = 2; i <= n; i++)
            {
                fibN = (fib1 + fib2) % 1000000007;
                fib1 = fib2;
                fib2 = fibN;
            }
            return fibN;
        }
    }
}
