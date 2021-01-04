using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer20
{

    public class Solution
    {
        int index = 0;
        public bool IsNumber(string s)
        {
            if (s.Length == 0) return false;
            s = s + '|';
            while (s[index] == ' ')
            {
                index++;
            }
            bool result = false;
            result = ScanInteger(s);
            if (s[index] == '.')
            {
                index++;
                result = ScanUnsignInteger(s) || result;
            }
            if (s[index] == 'e' || s[index] == 'E')
            {
                index++;
                result = ScanInteger(s) && result;
            }
            while (s[index] == ' ')
            {
                index++;
            }
            result = result && s[index] == '|';
            return result;
        }
        public bool ScanInteger(string s)
        {
            if (s[index] == '+' || s[index] == '-')
            {
                index++;
            }
            return ScanUnsignInteger(s);
        }
        public bool ScanUnsignInteger(string s)
        {
            int flag = index;
            while (s[index] >= '0' && s[index] <= '9')
            {
                index++;
            }
            return index > flag;
        }
    }

}
