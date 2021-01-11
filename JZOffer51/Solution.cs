using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer51
{
    public class Solution
    {
        int res = 0;
        public int ReversePairs(int[] nums)
        {
            if (nums.Length == 0) return 0;
            MergeSort(nums, 0, nums.Length - 1);
            return res;

        }
        public void MergeSort(int[] nums, int left, int right)
        {
            if (left == right) return;
            int mid = left + (right - left) / 2;
            MergeSort(nums, left, mid);
            MergeSort(nums, mid + 1, right);
            Merge(nums, left, right);
        }
        public void Merge(int[] nums, int left, int right)
        {
            int mid = left + (right - left) / 2;
            int f1 = left;
            int f2 = mid + 1;
            int[] temp = new int[right - left + 1];
            int i = 0;
            while (f1 <= mid && f2 <= right)
            {
                if (nums[f1] <= nums[f2])
                {
                    temp[i] = nums[f1];
                    i++;
                    f1++;
                }
                else
                {
                    res += mid - f1 + 1;
                    temp[i] = nums[f2];
                    i++;
                    f2++;
                }
            }
            while (f1 <= mid)
            {
                temp[i] = nums[f1];
                i++;
                f1++;
            }
            while (f2 <= right)
            {
                temp[i] = nums[f2];
                i++;
                f2++;
            }
            for (int j = 0; j <= right - left; j++)
            {
                nums[j + left] = temp[j];
            }
        }
    }
}
