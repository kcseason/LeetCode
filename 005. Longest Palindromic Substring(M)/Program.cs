using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.Longest_Palindromic_Substring_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = "whdqcudjpisufnrtsyupwtnnbsvfptrcgvobbjglmpynebblpigaflpbezjvjgbmofejyjssdhbgghgrhzuplbeptpaecfdanhlylgusptlgobkqnulxvnwuzwauewcplnvcwowmbxxnhsdmgxtvbfgnuqdpxennqglgmspbagvmjcmzmbsuacxlqfxjggrwsnbblnnwisvmpwwhomyjylbtedzrptejjsaiqzprnadkjxeqfdpkddmbzokkegtypxaafodjdwirynzurzkjzrkufsokhcdkajwmqvhcbzcnysrbsfxhfvtodqabvbuosxtonbpmgoemcgkudandrioncjigbyizekiakmrfjvezuzddjxqyevyenuebfwugqelxwpirsoyixowcmtgosuggrkdciehktojageynqkazsqxraimeopcsjxcdtzhlbvtlvzytgblwkmbfwmggrkpioeofkrmfdgfwknrbaimhefpzckrzwdvddhdqujffwvtvfyjlimkljrsnnhudyejcrtrwvtsbkxaplchgbikscfcbhovlepdojmqybzhbiionyjxqsmquehkhzdiawfxunguhqhkxqdiiwsbuhosebxrpcstpklukjcsnnzpbylzaoyrmyjatuovmaqiwfdfwyhugbeehdzeozdrvcvghekusiahfxhlzclhbegdnvkzeoafodnqbtanfwixjzirnoaiqamjgkcapeopbzbgtxsjhqurbpbuduqjziznblrhxbydxsmtjdfeepntijqpkuwmqezkhnkwbvwgnkxmkyhlbfuwaslmjzlhocsgtoujabbexvxweigplmlewumcone";
            //DateTime start1 = DateTime.Now;
            //Console.WriteLine(new Solution().LongestPalindrome(test));
            //TimeSpan ts1 = DateTime.Now - start1;
            //DateTime start2 = DateTime.Now;
            //Console.WriteLine(new Solution1().LongestPalindrome(test));
            //TimeSpan ts2 = DateTime.Now - start2;
            while (true)
                Console.WriteLine(new Solution().LongestPalindrome(Console.ReadLine()));
        }
    }

    // 穷举法 O(n3)
    public class Solution1
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var maxSubStr = string.Empty;
            var length = s.Length;
            var str = new List<string>();
            // 求出所有子串O(n2)+求证是否回文字符串O(n2)=O(n3)
            for (int start = 0; start < length; start++)
            {
                for (int end = start + 1; end < length; end++)
                {
                    var subStr = s.Substring(start, end - start + 1);
                    if (IsPalindromic(subStr) && subStr.Length > maxSubStr.Length)
                        maxSubStr = subStr;
                }
            }

            if (string.IsNullOrEmpty(maxSubStr))
                return s[s.Length - 1].ToString();

            return maxSubStr;
        }
        // 是否回文字符串
        public bool IsPalindromic(string subStr)
        {
            for (int i = 0; i < subStr.Length / 2; i++)
                if (!subStr[i].Equals(subStr[subStr.Length - i - 1]))
                    return false;

            return true;
        }
    }

    // 分治法 O(n2)
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var maxSubStr = string.Empty;
            var length = s.Length;

            if (string.IsNullOrEmpty(s))
                return string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var tempStr = L2rHelper(s, i);
                if (tempStr.Length >= maxSubStr.Length)
                    maxSubStr = tempStr;
            }

            if (string.IsNullOrEmpty(maxSubStr))
                return s[s.Length - 1].ToString();

            return maxSubStr;
        }

        // 在一段字符串中指定中轴寻找回文串
        public string L2rHelper(string s, int mid)
        {
            var left = mid - 1;
            var right = mid + 1;
            var length = s.Length;

            // baccab
            while (right < length && s[mid].Equals(s[right]))
                right++;

            while (left >= 0 && right < length && s[left].Equals(s[right]))
            {
                left--;
                right++;
            }

            return s.Substring(left + 1, right - left - 1);
        }
    }
}
