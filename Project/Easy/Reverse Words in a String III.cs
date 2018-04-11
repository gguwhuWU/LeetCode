using System;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// 557. Reverse Words in a String III
    /// Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
    /// Example 1:
    /// Input: "Let's take LeetCode contest"
    /// Output: "s'teL ekat edoCteeL tsetnoc"
    /// Note: In the string, each word is separated by single space and there will not be any extra space in the string.
    /// 使用 StringBuilder 而不用 string 是因為一些testCase會出現記憶體限制問題
    /// </summary>
    public class Reverse_Words_in_a_String_III
    {
        public string ReverseWords(string s)
        {
            var sList = s.Split(' ').ToList();
            StringBuilder result = new StringBuilder();

            foreach (var sOne in sList)
            {
                result.Append(" " + String.Join("", sOne.Select(c => c.ToString()).Reverse().ToList()));
            }

            return result.ToString().TrimStart();
        }
    }
}
