using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer04
{
    public class Solution
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int row = 0;
            int column = columns - 1;
            while (row < matrix.Length && column >= 0)
            {
                if (target == matrix[row][column])
                {
                    return true;
                }
                else if (target > matrix[row][column])
                {
                    row++;
                }
                else
                {
                    column--;
                }
            }
            return false;

        }
    }
}
