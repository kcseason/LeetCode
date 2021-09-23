using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那两个整数，
并返回他们的数组下标。
你可以假设每种输入只会对应一个答案。
但是，你不能重复利用这个数组中同样的元素。

示例:
给定 nums = [2, 7, 11, 15], target = 9
因为 nums[0] + nums[1] = 2 + 7 = 9
所以返回 [0, 1]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/two-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 **/

namespace _001.Two_Sum_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 3, 2, 5, 7 };
            Solution sol = new Solution();
            sol.TwoSum(input, 9);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complete = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // 不用加法，反向思维用减法，节约遍历字典时间
                if (complete.Keys.Contains(target - nums[i]))
                    return new int[] { complete[target - nums[i]], i };
                if (!complete.Keys.Contains(nums[i]))
                    complete.Add(nums[i], i);
            }

            return null;
        }
    }
}
