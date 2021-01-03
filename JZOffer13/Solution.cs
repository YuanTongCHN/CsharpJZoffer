using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer13
{
    public class Solution
    {
        public int MovingCount(int m, int n, int k)
        {
            bool[,] record = new bool[m, n];
            return Move(0, 0, record, m, n, k);
        }
        public int Move(int y, int x, bool[,] record, int m, int n, int k)
        {
            bool canNotMove = false;
            if (y / 10 + y % 10 + x / 10 + x % 10 > k)
            {
                canNotMove = true;
            }
            if (x < 0 || x >= n || y < 0 || y >= m || record[y, x] || canNotMove)
            {
                return 0;
            }
            record[y, x] = true;
            return 1 + Move(y + 1, x, record, m, n, k) + Move(y - 1, x, record, m, n, k) + Move(y, x + 1, record, m, n, k) + Move(y, x - 1, record, m, n, k);
        }
    }
}
