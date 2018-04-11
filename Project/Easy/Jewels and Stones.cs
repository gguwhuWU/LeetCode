using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 771. Jewels and Stones
    /// You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
    /// The letters in J are guaranteed distinct, and all characters in J and S are letters.Letters are case sensitive, so "a" is considered a different type of stone from "A".
    /// </summary>
    public class Jewels_and_Stones
    {
        public int NumJewelsInStones(string J, string S)
        {
            List<string> jList = J.Select(c => c.ToString()).ToList();
            List<string> sList = S.Select(c => c.ToString()).ToList();
            Hashtable ht = new Hashtable();
            int result = 0;

            foreach (var sOne in sList)
            {
                if (ht.Contains(sOne))
                {
                    ht[sOne] = (int)ht[sOne] + 1;
                }
                else
                {
                    ht.Add(sOne, 1);
                }
            }

            foreach (var jOne in jList)
            {
                if (ht.Contains(jOne))
                {
                    result = result + (int)ht[jOne];
                }
            }

            return result;
        }
    }
}
