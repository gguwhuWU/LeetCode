using System;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 7. Reverse Integer
    /// Given a 32-bit signed integer, reverse digits of an integer.
    /// Note:
    /// Assume we are dealing with an environment which could only hold integers within the 32-bit signed integer range.For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
    /// </summary>
    public class Reverse_Integer
    {
        public int Reverse(int x)
        {

            bool negativeNumber = false;
            long all = Convert.ToInt64(x);

            if (all < 0)
            {
                negativeNumber = true;
                all = Math.Abs(all);
            }

            string s = all.ToString();
            var r = s.Reverse().ToList().Select(c => c.ToString());
            string ss = String.Join("", r.ToArray());

            return testmethod2(ss, negativeNumber);
        }

        private static int testmethod2(string ss, bool negativeNumber)
        {

            long all = long.Parse(ss);

            if (Math.Abs(all) > int.MaxValue)
            {
                return 0;
            }

            if (negativeNumber)
            {
                ss = "-" + ss;
                all = long.Parse(ss);
            }

            return Convert.ToInt32(all);
        }
    }
}
