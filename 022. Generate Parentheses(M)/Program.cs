using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022.Generate_Parentheses_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().GenerateParenthesis(Convert.ToInt32(Console.ReadLine())));
        }
    }

    /**
     * 可使用递归向字符串里添加"("或者")"
     * 左括号的数量必须大于右括号的数量才能添加右括号
     **/
    public class Solution
    {
        public IList<string> ans;
        public IList<string> GenerateParenthesis(int n)
        {
            ans = new List<string>();
            var m = n;
            var k = n;

            Fn("", n, m, 2 * k);
            return ans;
        }

        public void Fn(string s, int n, int m, int kk)
        {
            if (m < n || m < 0 || n < 0)
                return;

            if (m == 0 && n == 0 && s.Length == kk)
            {
                ans.Add(s);
                return;
            }

            Fn(s + "(", n - 1, m, kk);
            Fn(s + ")", n, m - 1, kk);
        }
    }
}
