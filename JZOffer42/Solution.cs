using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer42
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int sum = nums[0];
            int maxSum = sum;

            for (int i = 1; i < nums.Length; i++)
            {
                if (sum < 0)
                {
                    sum = nums[i];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
                else
                {
                    sum += nums[i];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}
