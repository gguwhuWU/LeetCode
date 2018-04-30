using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /// <summary>
    /// 338. Counting Bits
    /// Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.
    /// Example:
    /// For num = 5 you should return [0,1,1,2,1,2].
    /// Follow up:
    /// It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
    /// Space complexity should be O(n).
    /// Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
    /// </summary>
    public class Counting_Bits
    {
        public int[] CountBits(int num)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= num; i++)
            {
                //result.Add(Regex.Matches(Convert.ToString(i, 2), "1").Count);
                //result.Add(Convert.ToString(i, 2).Split('1').Count() - 1);
                string target = Convert.ToString(i, 2);
                string strReplace = target.Replace("1", "");
                int times = target.Length - strReplace.Length;
                result.Add(times);
            }

            return result.ToArray();
        }
    }
}
