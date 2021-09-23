using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

示例 1:

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/longest-substring-without-repeating-characters
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
**/

namespace _003.Longest_Substring_Without_Repeating_Characters_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().LengthOfLongestSubstring(Console.ReadLine()));
        }
    }

    /*
     * avbam -> vbam = avb
     * avbaa -> vbaa -> a = avb
     * 
     * 
     */
    //public class Solution
    //{
    //    public int LengthOfLongestSubstring(string s)
    //    {
    //        int n = s.Length, ans = 0;
    //        int[] index = new int[128];

    //        for (int j = 0, i = 0; j < n; j++)
    //        {
    //            int vl = index[s[j]];
    //            i = Math.Max(vl, i);
    //            ans = Math.Max(ans, j - i + 1); //挑选最大长度值
    //            index[s[j]] = j + 1;
    //        }
    //        return ans;
    //    }
    //}

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            // 空串返回0
            if (string.IsNullOrEmpty(s))
                return 0;

            var max = 0;
            var start = 0;
            var end = 0;
            var charList = new List<char>();

            while (end < s.Length)
            {
                if (charList.Contains(s[end]))
                {
                    // 删除到不重复的那个字符为止
                    charList.Remove(s[start]);
                    start++;
                }
                else
                {
                    charList.Add(s[end]);
                    end++;
                }
                max = Math.Max(max, end - start);
            }

            return max;
        }
    }

    //public class Solution
    //{
    //    public int LengthOfLongestSubstring(string s)
    //    {
    //        if (string.IsNullOrEmpty(s))
    //            return 0;

    //        int head = 0;
    //        int maxlength = 0;
    //        Dictionary<char, int> charList = new Dictionary<char, int>();

    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            if (charList.Keys.Contains(s[i]))
    //            {
    //                int nowLength = i - head;
    //                maxlength = nowLength > maxlength ? nowLength : maxlength;

    //                int delteLength = charList[s[i]] - head;
    //                for (int j = head; j < head + delteLength; j++)
    //                    if (charList.Keys.Contains(s[j]))
    //                        charList.Remove(s[j]);

    //                head += delteLength + 1;
    //                charList[s[i]] = i;//更新重复字符位置
    //            }
    //            else
    //            {
    //                charList.Add(s[i], i);
    //                if (maxlength < charList.Count)
    //                    maxlength++;
    //            }
    //        }

    //        return maxlength > 0 ? maxlength : s.Length;
    //    }
    //}
}
