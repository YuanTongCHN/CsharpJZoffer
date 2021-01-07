using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer45
{
    public class Solution
    {
        public string MinNumber(int[] nums)
        {
            if (nums.Length == 0) return "";
            QuickSort(nums, 0, nums.Length - 1);
            string res = "";
            for (int i = 0; i < nums.Length; i++)
            {
                res += nums[i].ToString();
            }
            return res;
        }
        public void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end) return;
            int leftFlag = start + 1;
            int rightFlag = end;
            while (true)
            {
                while (leftFlag <= end)
                {
                    //if (nums[leftFlag] >= nums[start])
                    if (string.Compare(nums[leftFlag].ToString() + nums[start].ToString(), nums[start].ToString() + nums[leftFlag].ToString(), true) == 1)
                    {
                        break;
                    }
                    leftFlag++;
                }
                while (rightFlag >= start + 1)
                {
                    if (string.Compare(nums[rightFlag].ToString() + nums[start].ToString(), nums[start].ToString() + nums[rightFlag].ToString(), true) == -1)
                    {
                        break;
                    }
                    rightFlag--;
                }
                if (leftFlag < rightFlag)
                {
                    int temp = nums[leftFlag];
                    nums[leftFlag] = nums[rightFlag];
                    nums[rightFlag] = temp;
                }
                else
                {
                    int temp = nums[start];
                    nums[start] = nums[rightFlag];
                    nums[rightFlag] = temp;
                    break;
                }
            }
            QuickSort(nums, start, rightFlag - 1);
            QuickSort(nums, rightFlag + 1, end);
        }
    }
}
