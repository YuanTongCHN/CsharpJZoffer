using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer29
{
    public class Solution
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return new int[0];
            }
            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            int[] res = new int[matrix.Length * matrix[0].Length];
            int index = 0;
            while (left <= right && top <= bottom)
            {
                for (int col = left; col <= right; col++)
                {
                    res[index] = matrix[top][col];
                    index++;
                }
                for (int row = top + 1; row <= bottom; row++)
                {
                    res[index] = matrix[row][right];
                    index++;
                }
                if (left < right && top < bottom)
                {
                    for (int col = right - 1; col >= left; col--)
                    {
                        res[index] = matrix[bottom][col];
                        index++;
                    }
                    for (int row = bottom - 1; row > top; row--)
                    {
                        res[index] = matrix[row][left];
                        index++;
                    }
                }
                left++;
                right--;
                top++;
                bottom--;
            }
            return res;
        }
    }
}
