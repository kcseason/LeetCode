using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？找出所有满足条件且不重复的三元组。

注意：答案中不可以包含重复的三元组。

例如, 给定数组 nums = [-1, 0, 1, 2, -1, -4]，

满足要求的三元组集合为：
[
  [-1, 0, 1],
  [-1, -1, 2]
]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/3sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */

namespace _015._3Sum_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 0, 2, 4, 6, 7, 8, 3, -8 };
            var res = new Solution().ThreeSum(array);
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

    public class Solution1
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();

            var dic1 = new List<SumItem>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var item = new SumItem(nums[i], i, nums[j], j, (0 - nums[i] - nums[j]), -1);
                    dic1.Add(item);
                }
            }

            var dic2 = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                var items = (from d in dic1
                             where d.Third == nums[i]
                             select d);
                foreach (SumItem item in items)
                {
                    if (i == item.FirstPos || i == item.SecondPos)
                        continue;
                    item.ThirdPos = i;

                    var temp = new List<int>() { item.First, item.Second, item.Third };
                    temp.Sort();

                    // 处理可能的重复组合
                    var oneTwoThree = temp[0] + "_" + temp[1] + "_" + temp[2];
                    if (!dic2.Contains(oneTwoThree))
                        dic2.Add(oneTwoThree);
                }
            }

            foreach (string s in dic2)
            {
                var subList = new List<int>() { 
                    Convert.ToInt32(s.Split('_')[0]) ,
                    Convert.ToInt32(s.Split('_')[1]) ,
                    Convert.ToInt32(s.Split('_')[2]) 
                };
                res.Add(subList);
            }

            return res;
        }

        public class SumItem
        {
            public int First { set; get; }
            public int FirstPos { set; get; }
            public int Second { set; get; }
            public int SecondPos { set; get; }
            public int Third { set; get; }
            public int ThirdPos { set; get; }

            public SumItem(int f, int fp, int s, int sp, int t, int tp)
            {
                First = f;
                FirstPos = fp >= 0 ? fp : -1;
                Second = s;
                SecondPos = sp >= 0 ? sp : -1;
                Third = t;
                ThirdPos = tp >= 0 ? tp : -1;
            }

        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //先固定 i，再计算三数之和是不是0
            //需认真分析是否有重复的三元组
            var res = new List<IList<int>>();
            var length = nums.Length;
            Array.Sort(nums);
            for (var i = 0; i < length - 2; i++)
            {
                //定义左右指针j和k
                //i为循环变量，可以认为先固定了i
                var j = i + 1;
                var k = length - 1;
                //分析j和k
                while (j < k)
                {
                    //若和大于0，则需要减整体的值，将右指针 k 减1
                    if (nums[i] + nums[j] + nums[k] > 0)
                        k--;
                    //若和小于0，则需要加整体的值，将左指针 j 加1
                    else if (nums[i] + nums[j] + nums[k] < 0)
                        j++;
                    else
                    {
                        //若和正好等于0，将其存放进结果中
                        //然后需要处理重复三元组的情况
                        //不重复三元组需要3个索引各不相同并且组成的值的结果不能重复
                        //以下3个条件组成了满足不重复三元组的所有条件
                        //条件1：i、j、k的顺序具有稳定性，总是从小到大
                        res.Add(new int[] { nums[i], nums[j], nums[k] });
                        //首先使用 j + 1 <= nums.Length - 1 保证数组不越界
                        //条件2：再向右找到第1个值不和当前左指针相同的值的索引
                        //若为 1，1，1，1，1，2，找到2
                        while (j + 1 <= nums.Length - 1 && nums[j + 1] == nums[j++]) { }
                    }
                }
                //条件3：向右找到最后1个和当前被固定的 i 的值相同的值的索引
                //若为 1，1，1，1，1，2，找到2前面的最后一个1
                while (i + 1 <= nums.Length - 1 && nums[i + 1] == nums[i])
                    i++;
            }
            return res;
        }
    }
}
