using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer03
{
    public class Solution
    {
        public int findRepeatNumber(int[] nums)
        {
            //原地置换，索引与数字一一对应
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[nums[i]] != nums[i])
                {
                    Swap(nums, i, nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return nums[i];
                }
            }
            return -1;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
