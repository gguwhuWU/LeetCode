using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 561. Array Partition I
    /// Given an array of 2n integers, your task is to group these integers into n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.
    /// n is a positive integer, which is in the range of [1, 10000].
    /// All the integers in the array will be in the range of[-10000, 10000].
    /// </summary>
    public class Array_Partition_I
    {
        public int ArrayPairSum(int[] nums)
        {
            int result = 0;

            List<int> numsList = nums.OrderBy(i => i).ToList();

            for (int i = 0; i < numsList.Count; i = i + 2)
            {
                result = result + Math.Min(numsList[i], numsList[i+1]);
            }

            return result;
        }
    }
}
