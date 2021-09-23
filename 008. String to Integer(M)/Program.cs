using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
请你来实现一个 atoi 函数，使其能将字符串转换成整数。

首先，该函数会根据需要丢弃无用的开头空格字符，直到寻找到第一个非空格的字符为止。

当我们寻找到的第一个非空字符为正或者负号时，则将该符号与之后面尽可能多的连续数字组合起来，作为该整数的正负号；假如第一个非空字符是数字，则直接将其与之后连续的数字字符组合起来，形成整数。

该字符串除了有效的整数部分之后也可能会存在多余的字符，这些字符可以被忽略，它们对于函数不应该造成影响。

注意：假如该字符串中的第一个非空格字符不是一个有效整数字符、字符串为空或字符串仅包含空白字符时，则你的函数不需要进行转换。

在任何情况下，若函数不能进行有效的转换时，请返回 0。

说明：

假设我们的环境只能存储 32 位大小的有符号整数，那么其数值范围为 [−231,  231 − 1]。如果数值超过这个范围，请返回  INT_MAX (231 − 1) 或 INT_MIN (−231) 。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/string-to-integer-atoi
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */
namespace _008.String_to_Integer_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().MyAtoi(Console.ReadLine()));
        }
    }

    public class Solution
    {
        public int MyAtoi(string str)
        {
            //str = str.Trim().TrimStart('0');//清除左边无效空格和0字符
            str = str.Trim();//清除左边无效空格
            if (string.IsNullOrEmpty(str))
                return 0;

            int end = 1;
            if (str[0] != '-' && str[0] != '+' && (str[0] < '0' || str[0] > '9'))
                return 0;//处理首字符

            if (str[0] == '-' || str[0] == '+')
                str = str[0] + str.Substring(1).TrimStart('0');//清除左边无效空格和0字符，处理-0000000000000001(超过11位)

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    break;//非数字字符直接跳出循环
                end++;
                //if (end > 11)
                //    break;//此处理为防止截取字符串长度超过long最大长度19位，int32为10位，加上+-号，有效数字到11位足以
            }

            str = str.Substring(0, end).TrimStart('0');//清除左边无效0字符

            if (string.IsNullOrWhiteSpace(str) || (end == 1 && (str[0] < '0' || str[0] > '9')))
                return 0;//处理-a,+a,-b类型

            //if (str.Length > 11)
            //    str = str.Substring(0, 11);
            end = end > str.Length ? str.Length : end;
            end = end > 12 ? 12 : end;
            long longNum = long.Parse(str.Substring(0, end));
            //long longNum = long.Parse(str);

            if (longNum > int.MaxValue)
                return int.MaxValue;
            if (longNum < int.MinValue)
                return int.MinValue;

            return (int)longNum;
        }
    }
}
