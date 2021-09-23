using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018._4Sum_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 0, 0, -1 };
            var res = new Solution().FourSum(array, 0);
            foreach (IList<int> list in res)
            {
                foreach (int i in list)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
            Console.Read();
            //while (true)
            //    Console.WriteLine(new Solution().ThreeSum(array));
        }
    }

    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var res = new List<IList<int>>();
            var length = nums.Length;
            Array.Sort(nums);

            for (var first = 0; first < length - 3; first++)
            {
                for (var second = first + 1; second < length - 2; second++)
                {
                    var third = second + 1;
                    var forth = length - 1;

                    while (third < forth)
                    {
                        var sum = nums[first] + nums[second] + nums[third] + nums[forth];
                        //若和大于0，则需要减整体的值，将右指针 k 减1
                        if (sum > target)
                            forth--;
                        //若和小于0，则需要加整体的值，将左指针 j 加1
                        else if (sum < target)
                            third++;
                        else
                        {
                            res.Add(new int[] { nums[first], nums[second], nums[third], nums[forth] });
                            //while (third + 1 <= nums.Length - 1 && nums[third + 1] == nums[third++]) { }
                            while (third + 1 <= nums.Length - 1 && nums[third + 1] == nums[third])
                                third++;
                            third++;
                        }
                    }
                    while (second + 1 <= nums.Length - 1 && nums[second + 1] == nums[second])
                        second++;
                }
                while (first + 1 <= nums.Length - 1 && nums[first + 1] == nums[first])
                    first++;
            }

            return res;
        }
    }
}
