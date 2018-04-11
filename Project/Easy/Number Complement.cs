using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 476. Number Complement
    /// Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.
    /// Note:
    /// The given integer is guaranteed to fit within the range of a 32-bit signed integer.
    /// You could assume no leading zero bit in the integer’s binary representation.
    /// Example 1:
    /// Input: 5
    /// Output: 2
    /// Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
    /// </summary>
    public class Number_Complement
    {
        public int FindComplement(int num)
        {
            string binary = Convert.ToString(num, 2);
            List<string> binaryList = binary.Select(c => c.ToString()).ToList();
            string complement = "";

            foreach (var binaryOne in binaryList)
            {
                switch (binaryOne)
                {
                    case "0":
                        {
                            complement = complement + "1";
                            break;
                        }
                    case "1":
                        {
                            complement = complement + "0";
                            break;
                        }
                }
            }

            return Convert.ToInt32(complement, 2);
        }
    }
}
