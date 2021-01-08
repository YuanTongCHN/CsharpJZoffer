using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer49
{
    public class Solution
    {
        public int NthUglyNumber(int n)
        {
            if (n <= 0) return 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int[] dp = new int[n];
            dp[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int n2 = dp[a] * 2;
                int n3 = dp[b] * 3;
                int n5 = dp[c] * 5;
                dp[i] = Math.Min(Math.Min(n2, n3), n5);
                if (dp[i] == n2) a++;
                if (dp[i] == n3) b++;
                if (dp[i] == n5) c++;

            }
            return dp[n - 1];
        }
    }
}
