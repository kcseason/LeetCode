using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

示例 1:

输入: 123
输出: 321
 示例 2:

输入: -123
输出: -321
示例 3:

输入: 120
输出: 21
注意:

假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/reverse-integer
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * 
 * */
namespace _007.Reverse_Integer_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().Reverse(Convert.ToInt32(Console.ReadLine())));
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            long longNum = 0;
            while (x != 0)
            {
                // 求模获取最后几位数字，整除获取前面几位数字 
                longNum = longNum * 10 + x % 10;
                x = x / 10;
            }

            return longNum > int.MaxValue || longNum < int.MinValue ? 0 : (int)longNum;
        }
    }
}
