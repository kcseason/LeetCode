using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344.Reverse_String_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().ReverseString(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var charArray = new char[s.Length];
            for (int i = s.Length - 1; i >= 0; i--)
                charArray[s.Length - 1 - i] = s[i];

            return new string(charArray);
        }
    }
}
