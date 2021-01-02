using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer05
{
    public class Solution
    {
        public String replaceSpace(String s)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    res.Append("%20");
                }
                else
                {
                    res.Append(s[i]);
                }
            }
            return res.ToString();
        }
    }
}
