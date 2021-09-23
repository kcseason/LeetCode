using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014.Longest_Common_Prefix_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "a"}));
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;
            if (strs.Length == 1)
                return strs[0];

            var ans = "";
            var endPoint = false;
            for (int i = 0; i < strs[0].Length; i++)
            {
                if (endPoint)
                    break;
                var curChar = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if ((i + 1) > strs[j].Length)
                    {
                        endPoint = true;
                        break;
                    }
                    if (strs[j][i].Equals(curChar) && (j + 1) == strs.Length)
                        ans += curChar;
                    else if (!strs[j][i].Equals(curChar))
                    {
                        endPoint = true;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
