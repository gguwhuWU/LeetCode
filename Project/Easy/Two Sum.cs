namespace LeetCode.Easy
{
    /// <summary>
    /// 1. Two Sum
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// </summary>
    public class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if ((nums[i] + nums[j]) == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }

            return new int[] { 0, 1 };
        }
    }
}
