using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer19
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (s.Length == 0)
            {
                if (p.Length % 2 != 0) return false;
                else
                {
                    int i = 1;
                    while (i < p.Length)
                    {
                        if (p[i] != '*') return false;
                        i += 2;
                    }
                    return true;
                }
            }
            if (p.Length == 0) return false;
            char c = p[0];
            if (p.Length > 1)
            {
                c = p[1];
            }
            if (c != '*')
            {
                if (s[0] == p[0] || p[0] == '.')
                {
                    return IsMatch(s.Substring(1), p.Substring(1));
                }
                return false;
            }
            else
            {
                if (s[0] != p[0] && p[0] != '.') return IsMatch(s, p.Substring(2));
                else return IsMatch(s, p.Substring(2)) || IsMatch(s.Substring(1), p);
            }
        }
    }
}
