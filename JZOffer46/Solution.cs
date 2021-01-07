using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer46
{
    public class Solution
    {
        public int TranslateNum(int num)
        {
            String str = num.ToString();
            if (str.Length <= 1) return 1;
            int[] dp = new int[str.Length + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= str.Length; i++)
            {
                String temp = str.Substring(i - 2, 2);
                if (temp.CompareTo("10") >= 0 && temp.CompareTo("25") <= 0)
                {
                    dp[i] = dp[i - 2] + dp[i - 1];
                }
                else
                {
                    dp[i] = dp[i - 1];
                }
            }
            return dp[str.Length];
        }
    }
}
