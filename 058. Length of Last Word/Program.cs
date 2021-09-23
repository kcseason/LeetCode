using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058.Length_of_Last_Word_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().LengthOfLastWord(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            var charArr = s.Split(' ');
            if (charArr.Length == 0)
                return 0;
            return charArr.Last().Length;
        }
    }
}
