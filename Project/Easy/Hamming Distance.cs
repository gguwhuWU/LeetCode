using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 461. Hamming Distance
    /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// Given two integers x and y, calculate the Hamming distance.
    /// </summary>
    public class Hamming_Distance
    {
        public int HammingDistance(int x, int y)
        {
            var xb = Convert.ToString(x, 2).Reverse().Select(c => c.ToString()).ToList();
            var yb = Convert.ToString(y, 2).Reverse().Select(c => c.ToString()).ToList();
            int result = 0;
            int comnpareLenght = xb.Count;
            List<string> bigList = yb;

            if (xb.Count > yb.Count)
            {
                comnpareLenght = yb.Count;
                bigList = xb;
            }

            for (int i = 0; i < comnpareLenght; i++)
            {
                if (xb[i] != yb[i])
                {
                    result++;
                }
            }

            for (int i = comnpareLenght; i < bigList.Count; i++)
            {
                if (bigList[i] == "1")
                {
                    result++;
                }
            }

            return result;
        }
    }
}
