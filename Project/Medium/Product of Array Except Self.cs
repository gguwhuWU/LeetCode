using System;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    /// 238. Product of Array Except Self
    /// Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
    /// Solve it without division and in O(n).
    /// For example, given[1, 2, 3, 4], return [24,12,8,6].
    /// Follow up:
    /// Could you solve it with constant space complexity? (Note: The output array does not count as extra space for the purpose of space complexity analysis.)
    /// </summary>
    public class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums.ToList();
                temp.RemoveAt(i);
                
                if (temp.Contains(0))
                {
                    result[i] = 0;
                    continue;
                }

                bool isNegative = false;
                if (temp.Where(v => v < 0).Count() % 2 != 0)
                {
                    isNegative = true;
                }

                temp = temp.Select(v => Math.Abs(v)).Where(v => v != 1).ToList();

                if (temp.Count() == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = temp.Aggregate(1, (x, y) => x * y);
                }

                if (isNegative)
                {
                    result[i] = -result[i];
                }

            }

            return result;
        }
    }
}
