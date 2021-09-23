﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

示例 1:

输入: 121
输出: true
示例 2:

输入: -121
输出: false
解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
示例 3:

输入: 10
输出: false
解释: 从右向左读, 为 01 。因此它不是一个回文数。
进阶:

你能不将整数转为字符串来解决这个问题吗？

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/palindrome-number
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */

namespace _009.Palindrome_Number_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().IsPalindrome(Convert.ToInt32(Console.ReadLine())).ToString());
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var subStr = x.ToString();
            for (int i = 0; i < subStr.Length / 2; i++)
                if (!subStr[i].Equals(subStr[subStr.Length - i - 1]))
                    return false;

            return true;
        }
    }
}
