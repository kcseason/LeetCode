using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016._3Sum_Cloest_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { -1, 2, 1, -4 };
            var res = new Solution().ThreeSumClosest(array, 1);
            Console.WriteLine(res);
            Console.Read();
        }
    }

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var minSum = nums[0] + nums[1] + nums[2];
            var length = nums.Length;
            Array.Sort(nums);
            for (var i = 0; i < length - 2; i++)
            {
                //定义左右指针j和k
                //i为循环变量，可以认为先固定了i
                var start = i + 1;
                var end = length - 1;
                //分析j和k
                while (start < end)
                {
                    var sum = nums[i] + nums[start] + nums[end];
                    if (Math.Abs(target - sum) < Math.Abs(target - minSum))
                        minSum = sum;

                    if (sum > target)
                        end--;
                    else if (sum < target)
                        start++;
                    else
                        return minSum;
                }
            }

            return minSum;
        }
    }
}
