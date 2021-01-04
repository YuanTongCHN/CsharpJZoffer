using System;
namespace CsharpJZoffer.JZOffer39
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int result = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    result = nums[i];
                    count = 1;
                }
                else if (result == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return result;
        }
    }
}
