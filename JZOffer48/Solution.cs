using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer48
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {

            //if (s.Length <= 0)
            //{
            //    return 0;
            //}
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int temp = 0;
            int maxOfDp = 0;
            for (int j = 0; j < s.Length; j++)
            {
                int i = dic.GetValueOrDefault(s[j], -1);
                if (dic.ContainsKey(s[j]))
                {
                    dic[s[j]] = j;
                }
                else
                {
                    dic.Add(s[j], j);
                }
                int d = j - i;
                if (temp < d)
                {
                    temp = temp + 1;
                }
                else
                {
                    temp = d;
                }
                maxOfDp = Math.Max(maxOfDp, temp);
            }
            return maxOfDp;
        }
    }
}
