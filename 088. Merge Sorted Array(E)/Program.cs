using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定两个有序整数数组 nums1 和 nums2，将 nums2 合并到 nums1 中，使得 num1 成为一个有序数组。

说明:

初始化 nums1 和 nums2 的元素数量分别为 m 和 n。
你可以假设 nums1 有足够的空间（空间大小大于或等于 m + n）来保存 nums2 中的元素。
示例:

输入:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

输出: [1,2,2,3,5,6]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/merge-sorted-array
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */
namespace _088.Merge_Sorted_Array_E_
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var len1 = m - 1;
            var len2 = n - 1;
            var len = m + n - 1;

            while (len1 >= 0 && len2 >= 0)
            {
                // 注意--符号在后面，表示先进行计算再减1，这种缩写缩短了代码
                nums1[len--] = nums1[len1] > nums2[len2] ? nums1[len1--] : nums2[len2--];
            }

            Array.Copy(nums2, 0, nums1, 0, len2 + 1);
        }
    }
}
