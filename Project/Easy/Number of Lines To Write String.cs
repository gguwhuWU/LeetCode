using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 806. Number of Lines To Write String
    /// We are to write the letters of a given string S, from left to right into lines. Each line has maximum width 100 units, and if writing a letter would cause the width of the line to exceed 100 units, it is written on the next line. We are given an array widths, an array where widths[0] is the width of 'a', widths[1] is the width of 'b', ..., and widths[25] is the width of 'z'.
    /// Now answer two questions: how many lines have at least one character from S, and what is the width used by the last such line? Return your answer as an integer list of length 2.
    /// Note:
    /// The length of S will be in the range [1, 1000].
    /// S will only contain lowercase letters.
    /// widths is an array of length 26.
    /// widths[i] will be in the range of[2, 10].
    /// </summary>
    public class Number_of_Lines_To_Write_String
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            Hashtable ht = GetLettersHashTable(widths);
            List<string> sList = S.Select(c => c.ToString()).ToList();
            int line = 1;
            int lastLineCount = 0;
            int tempLine = 0;

            foreach (var sOne in sList)
            {
                tempLine = tempLine + (int)ht[sOne];

                if (tempLine > 100)
                {
                    tempLine = (int)ht[sOne];
                    line++;
                }
            }

            lastLineCount = tempLine;
            return new int[] { line, lastLineCount };
        }

        private static Hashtable GetLettersHashTable(int[] widths)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i <= 25; i++)
            {
                ht.Add(Convert.ToChar(97 + i).ToString(), widths[i]);
            }

            return ht;
        }
    }
}
