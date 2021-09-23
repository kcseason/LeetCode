using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066.PlusOne_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().PlusOne(new int[] { 9, 9, 9, 9 }));
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = digits[i] + 1 == 10 ? 0 : digits[i] + 1;
                if (digits[i] != 0)
                    return digits;
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }
    }
}
