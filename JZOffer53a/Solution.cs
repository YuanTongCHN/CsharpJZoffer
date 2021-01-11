using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer53a
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int midIndex = GetMidIndex(nums, target, 0, nums.Length - 1);
            if (midIndex < 0) return 0;
            int left = GetFirstIndex(nums, target, 0, midIndex);
            int right = GetLastIndex(nums, target, midIndex, nums.Length - 1);
            Console.WriteLine(right);
            Console.WriteLine(left);
            return right - left + 1;

        }
        public int GetMidIndex(int[] nums, int target, int minIndex, int maxIndex)
        {
            if (nums.Length <= 0) return -1;
            if (minIndex == maxIndex)
            {
                if (nums[minIndex] == target) return minIndex;
                else return -1;
            }
            int mid = (minIndex + maxIndex) / 2;
            if (nums[mid] > target)
            {
                if (mid <= minIndex) return -1;
                else return GetMidIndex(nums, target, minIndex, mid - 1);
            }
            else if (nums[mid] < target)
            {
                if (mid >= maxIndex) return -1;
                return GetMidIndex(nums, target, mid + 1, maxIndex);
            }
            else
            {
                return mid;
            }
        }
        public int GetFirstIndex(int[] nums, int target, int minIndex, int maxIndex)
        {
            if (minIndex == maxIndex) return minIndex;
            int mid = (maxIndex + minIndex) / 2;
            if (nums[mid] == target)
            {
                if (mid == minIndex || nums[mid - 1] != target)
                {
                    return mid;
                }
                else
                {
                    return GetFirstIndex(nums, target, minIndex, mid - 1);
                }
            }
            else
            {
                return GetFirstIndex(nums, target, mid + 1, maxIndex);
            }
        }
        public int GetLastIndex(int[] nums, int target, int minIndex, int maxIndex)
        {
            if (minIndex == maxIndex) return maxIndex;
            int mid = (maxIndex + minIndex) / 2;
            if (nums[mid] == target)
            {
                if (mid == maxIndex || nums[mid + 1] != target)
                {
                    return mid;
                }
                else
                {
                    return GetLastIndex(nums, target, mid + 1, maxIndex);
                }
            }
            else
            {
                return GetLastIndex(nums, target, minIndex, mid - 1);
            }
        }
    }
}
