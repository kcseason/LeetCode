using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _187.FindRepeatedDnaSequences_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                foreach (string str in new Solution().FindRepeatedDnaSequences(s))
                    Console.WriteLine(str);
            }
        }
    }

    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            List<string> result = new List<string>();//记录重复超过1次字符串
            Dictionary<string, int> repeatStr = new Dictionary<string, int>();//记录所有重复字符串
            if (String.IsNullOrEmpty(s))
                return result;

            for (int i = 0; i <= s.Length - 10; i++)
            {
                string str = s.Substring(i, 10);
                if (repeatStr.Keys.Contains(str))
                    repeatStr[str]++;
                else
                    repeatStr.Add(str, 1);
            }

            foreach (KeyValuePair<string, int> pair in repeatStr)
                if (pair.Value > 1)
                    result.Add(pair.Key);

            return result;
        }
    }
}
