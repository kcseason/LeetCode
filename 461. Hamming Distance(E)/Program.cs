using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461.Hamming_Distance_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = new Solution().HammingDistance(1, 4);
        }
    }
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            string str1 = Convert.ToString(x, 2);
            string str2 = Convert.ToString(y, 2);
            if (str1.Length - str2.Length > 0)
                str2 = str2.PadLeft(str1.Length, '0');
            if (str2.Length - str1.Length > 0)
                str1 = str1.PadLeft(str2.Length, '0');
            int diff = 0;
            for (int i = 0; i < str1.Length; i++)
                if (str1[i] != str2[i])
                    diff++;

            return diff;
        }
    }
}
