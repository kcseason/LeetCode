using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035.Search_Insert_Position_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().SearchInsert(new int[] { }, 0));
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                    return i;
                else if (i + 1 == nums.Length)
                    return i + 1;
            }

            return ans;
        }
    }
}
