using System;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 344. Reverse String
    /// Write a function that takes a string as input and returns the string reversed.
    /// Example:
    /// Given s = "hello", return "olleh".
    /// </summary>
    public class Reverse_String
    {
        public string ReverseString(string s)
        {
            return String.Join("", s.Select(c => c.ToString()).Reverse().ToList());
        }
    }
}
