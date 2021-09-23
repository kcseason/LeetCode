using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067.Add_Binary_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().AddBinary("1001", "10"));
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var ans = new StringBuilder();
            var ca = 0;
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                var sum = ca;
                sum += i >= 0 ? a[i] - '0' : 0;
                sum += j >= 0 ? b[j] - '0' : 0;
                ans.Append(sum % 2);
                ca = sum / 2;
            }
            ans.Append(ca == 1 ? ca.ToString() : "");

            var ret = ans.ToString().ToCharArray();
            return string.Concat(ret.Reverse<char>());
        }
    }
}
