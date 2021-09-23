using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。
注意空字符串可被认为是有效字符串。

示例 1:

输入: "()"
输出: true
示例 2:

输入: "()[]{}"
输出: true
示例 3:

输入: "(]"
输出: false
示例 4:

输入: "([)]"
输出: false
示例 5:

输入: "{[]}"
输出: true

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/valid-parentheses
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 **/
namespace _020.Valid_Parentheses_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().IsValid(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var stack = new Stack<Char>();
            foreach (var c in s)
            {
                if (stack.Count == 0)
                    stack.Push(c);
                else
                {
                    var topChar = stack.Peek();
                    if (topChar.Equals('(') && c.Equals(')') ||
                        topChar.Equals('[') && c.Equals(']') ||
                        topChar.Equals('{') && c.Equals('}'))
                        stack.Pop();
                    else
                        stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }
}
