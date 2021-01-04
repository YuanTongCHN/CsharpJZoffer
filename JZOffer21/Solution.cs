using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer21
{
    public class Solution
    {
        public int[] Exchange(int[] nums)
        {
            int lflag = 0;
            int rflag = nums.Length - 1;
            while (lflag < rflag)
            {
                while (nums[lflag] % 2 != 0 && lflag < rflag)
                {
                    lflag++;
                }
                while (nums[rflag] % 2 == 0 && lflag < rflag)
                {
                    rflag--;
                }
                if (lflag < rflag)
                {
                    int temp = nums[lflag];
                    nums[lflag] = nums[rflag];
                    nums[rflag] = temp;
                }
            }
            return nums;
        }
    }
}
