using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer50
{
    public class Solution
    {
        public char FirstUniqChar(string s)
        {
            if (s.Length <= 0) return ' ';
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] += 1;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            for (int j = 0; j < s.Length; j++)
            {
                if (dic[s[j]] == 1) return s[j];
            }
            return ' ';
        }
    }
}
