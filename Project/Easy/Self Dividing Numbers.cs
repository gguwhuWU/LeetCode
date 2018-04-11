using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 728. Self Dividing Numbers
    /// A self-dividing number is a number that is divisible by every digit it contains.
    /// For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
    /// Also, a self-dividing number is not allowed to contain the digit zero.
    /// Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
    /// </summary>
    public class Self_Dividing_Numbers
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();

            for (; left <= right; left++)
            {
                if (left < 10)
                {
                    result.Add(left);
                    continue;
                }

                var sList = left.ToString().Select(c => c.ToString()).ToList();
                bool Is_self_dividing = true;

                foreach (var sOne in sList)
                {
                    int sOneByInt = Convert.ToInt32(sOne);

                    if (sOneByInt == 0)
                    {
                        Is_self_dividing = false;
                        break;
                    }

                    if (left % sOneByInt != 0)
                    {
                        Is_self_dividing = false;
                    }
                }

                if (Is_self_dividing)
                {
                    result.Add(left);
                }
            }

            return result;
        }
    }
}
