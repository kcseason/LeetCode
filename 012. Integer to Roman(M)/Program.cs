using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012.Integer_to_Roman_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(new Solution().IntToRoman(Convert.ToInt32(Console.ReadLine())));
        }
    }

    public class Solution
    {
        public string IntToRoman(int num)
        {
            var unit = new string[10] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            var ten = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var hundred = new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var thousand = new string[4] { "", "M", "MM", "MMM" };

            return thousand[num / 1000] + hundred[num % 1000 / 100] + ten[num % 100 / 10] + unit[num % 10];

        }

        //public string IntToRoman1(int num)
        //{
        //    var dic = new Dictionary<string, int> { 
        //    {"M",1000}, {"CM",900}, {"D",500},
        //    {"CD",400}, {"C",100}, {"XC",90}, {"L",50}, 
        //    {"XL",40}, {"X",10}, {"IX",9}, {"V",5}, {"IV",4}, {"I",1} };

        //    var result = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i + 1 < s.Length && dic.ContainsKey(s.Substring(i, 2)))
        //        {
        //            result += dic[s.Substring(i, 2)];
        //            i++;
        //        }
        //        else
        //            result += dic[s.Substring(i, 1)];
        //    }

        //    return result;

        //}
    }
}
