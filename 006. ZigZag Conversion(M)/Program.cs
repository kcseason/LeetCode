using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。

比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：

L   C   I   R
E T O E S I I G
E   D   H   N
之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。

请你实现这个将字符串进行指定行数变换的函数：

string convert(string s, int numRows);
示例 1:

输入: s = "LEETCODEISHIRING", numRows = 3
输出: "LCIRETOESIIGEDHN"
示例 2:

输入: s = "LEETCODEISHIRING", numRows = 4
输出: "LDREOEIIECIHNTSG"
解释:

L     D     R
E   O E   I I
E C   I H   N
T     S     G

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/zigzag-conversion
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
**/

namespace _006.ZigZag_Conversion_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().Convert("ABC", 1));
        }
    }

    public class Solution
    {
        // 从左到右按箭头方向迭代 s ，将每个字符添加到合适的行。之后从上到下遍历行即可
        // 0行和n-1行开始反转箭头
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            var res = new Dictionary<int, List<char>>();
            var curRow = 1;
            var goDown = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (res.Keys.Contains(curRow))
                    res[curRow].Add(s[i]);
                else
                    res.Add(curRow, new List<char> { s[i] });

                curRow = goDown ? curRow + 1 : curRow - 1;
                if (curRow % numRows == 0 || curRow % numRows == 1)
                    goDown = !goDown;
            }

            var outPut = string.Empty;
            for (int i = 1; i <= numRows; i++)
                if (res.Keys.Contains(i))
                    outPut = outPut + new string(res[i].ToArray());

            return outPut;
        }
    }
}
