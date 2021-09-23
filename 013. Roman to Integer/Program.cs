using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。

字符          数值
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。

通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：

I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。 
C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
给定一个罗马数字，将其转换成整数。输入确保在 1 到 3999 的范围内。

示例 1:

输入: "III"
输出: 3
示例 2:

输入: "IV"
输出: 4
示例 3:

输入: "IX"
输出: 9
示例 4:

输入: "LVIII"
输出: 58
解释: L = 50, V= 5, III = 3.
示例 5:

输入: "MCMXCIV"
输出: 1994
解释: M = 1000, CM = 900, XC = 90, IV = 4.

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/roman-to-integer
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */

namespace _013.Roman_to_Integer_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().RomanToInt(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public int RomanToInt1(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            var result = 0;
            var temp = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var cur = s[i];
                switch (cur)
                {
                    case 'I': temp = 1; break;
                    case 'V': temp = 5; break;
                    case 'X': temp = 10; break;
                    case 'L': temp = 50; break;
                    case 'C': temp = 100; break;
                    case 'D': temp = 500; break;
                    case 'M': temp = 1000; break;
                }
                if (i + 1 < s.Length)
                {
                    var nextTwo = s.Substring(i, 2);
                    switch (nextTwo)
                    {
                        case "IV": temp = 4; i++; break;
                        case "IX": temp = 9; i++; break;
                        case "XL": temp = 40; i++; break;
                        case "XC": temp = 90; i++; break;
                        case "CD": temp = 400; i++; break;
                        case "CM": temp = 900; i++; break;
                    }
                }
                result += temp;
            }
            return result;
        }

        public int RomanToInt(string s)
        {
            var dic = new Dictionary<string, int> { 
            {"M",1000}, {"CM",900}, {"D",500},
            {"CD",400}, {"C",100}, {"XC",90}, {"L",50}, 
            {"XL",40}, {"X",10}, {"IX",9}, {"V",5}, {"IV",4}, {"I",1} };

            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dic.ContainsKey(s.Substring(i, 2)))
                {
                    result += dic[s.Substring(i, 2)];
                    i++;
                }
                else
                    result += dic[s.Substring(i, 1)];
            }

            return result;
        }
    }
}
