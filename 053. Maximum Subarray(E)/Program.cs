using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053.Maximum_Subarray_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().MaxSubArray(new int[] { -1, -4, -3, -2, -5, -1, -2, 7 }));
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int ans = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum > 0)
                    sum += nums[i];
                else
                    sum = nums[i];
                ans = Math.Max(ans, sum);
            }
            return ans;
        }
    }
}
