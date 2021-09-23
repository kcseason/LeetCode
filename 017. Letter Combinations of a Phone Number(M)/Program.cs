using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。

给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。



示例:

输入："23"
输出：["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
说明:
尽管上面的答案是按字典序排列的，但是你可以任意选择答案输出的顺序。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */

namespace _017.Letter_Combinations_of_a_Phone_Number_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().LetterCombinations(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var ans = new List<string>();
            if (string.IsNullOrWhiteSpace(digits))
                return ans;

            var mapping = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            ans.Add("");

            for (int i = 0; i < digits.Length; i++)
            {
                var number = Convert.ToInt32(digits[i].ToString());
                while (ans.First().Length == i)
                {
                    var s = ans[0];
                    ans.RemoveAt(0);
                    var chars = mapping[number].ToCharArray();
                    foreach (var c  in chars)
                        ans.Add(s + c);
                }
            }

            return ans;
        }
    }
}
