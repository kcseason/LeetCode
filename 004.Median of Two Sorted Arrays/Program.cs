using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。

请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。

你可以假设 nums1 和 nums2 不会同时为空。

示例 1:

nums1 = [1, 3]
nums2 = [2]

则中位数是 2.0
示例 2:

nums1 = [1, 2]
nums2 = [3, 4]

则中位数是 (2 + 3)/2 = 2.5

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/median-of-two-sorted-arrays
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 **/

namespace _004.Median_of_Two_Sorted_Arrays_H_
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2, 4, 5, 6 };
            while (true)
                Console.WriteLine(new Solution().FindMedianSortedArrays(nums1, nums2));
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = new List<double>();
            var index1 = 0;
            var index2 = 0;
            var length1 = nums1 == null ? 0 : nums1.Length;
            var length2 = nums2 == null ? 0 : nums2.Length;

            while (index1 < length1 && index2 < length2)
            {
                if (nums1[index1] < nums2[index2])
                {
                    result.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    result.Add(nums2[index2]);
                    index2++;
                }
            }
            while (index1 < length1)
            {
                result.Add(nums1[index1]);
                index1++;
            }
            while (index2 < length2)
            {
                result.Add(nums2[index2]);
                index2++;
            }

            var length = result.Count;
            if (length % 2 == 0)
                return (result[length / 2 - 1] + result[length / 2]) / 2;
            else
                return result[length / 2];
        }
    }
}
