using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476.Number_Complement_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            new Solution().FindComplement(5);
        }
    }

    public class Solution
    {
        public int FindComplement(int num)
        {
            var str = Convert.ToString(num, 2);
            var sb = new StringBuilder();
            foreach (char c in str)
                sb.Append(c == '1' ? '0' : '1');
            return Convert.ToInt32(sb.ToString(), 2);
            //int mask = ~0;
            //string s = Convert.ToString(5, 2);
            //int mask2 = 0^5;
            //while ((num & mask) > 0)
            //{
            //    mask <<= 1;
            //}

            //int ans =  ~mask & ~num;
            //return ans;
        }
    }
}
