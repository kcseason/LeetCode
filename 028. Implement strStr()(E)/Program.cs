using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028.Implement_strStr___E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().StrStr("ssippi", "sipp"));
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (!haystack[i + j].Equals(needle[j]))
                        break;

                    if (j == needle.Length - 1)
                        return i;
                }
            }

            return -1;
        }
    }
}
