﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 811. Subdomain Visit Count
    /// A website domain like "discuss.leetcode.com" consists of various subdomains. At the top level, we have "com", at the next level, we have "leetcode.com", and at the lowest level, "discuss.leetcode.com". When we visit a domain like "discuss.leetcode.com", we will also visit the parent domains "leetcode.com" and "com" implicitly.
    /// Now, call a "count-paired domain" to be a count(representing the number of visits this domain received), followed by a space, followed by the address.An example of a count-paired domain might be "9001 discuss.leetcode.com".
    /// We are given a list cpdomains of count-paired domains.We would like a list of count-paired domains, (in the same format as the input, and in any order), that explicitly counts the number of visits to each subdomain.
    /// The length of cpdomains will not exceed 100. 
    /// The length of each domain name will not exceed 100.
    /// Each address will have either 1 or 2 "." characters.
    /// The input count in any count-paired domain will not exceed 10000.
    /// The answer output can be returned in any order.
    /// </summary>
    public class Subdomain_Visit_Count
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> result = new List<string>();
            Hashtable ht = new Hashtable();

            foreach (var cpdomain in cpdomains)
            {
                var cpdomainWithTwoType = cpdomain.Split(' ').ToList();
                int count = Convert.ToInt32(cpdomainWithTwoType[0]);
                var cpdomainWithLevelType = cpdomainWithTwoType[1].Split('.').ToList();
                string cpdomainString = "";

                for (int i = cpdomainWithLevelType.Count - 1; i >= 0; i--)
                {
                    if (cpdomainString.Equals(""))
                    {
                        cpdomainString = cpdomainWithLevelType[i];
                    }
                    else
                    {
                        cpdomainString = cpdomainWithLevelType[i] + "." + cpdomainString;
                    }

                    if (ht.Contains(cpdomainString))
                    {
                        ht[cpdomainString] = (int)ht[cpdomainString] + count;
                    }
                    else
                    {
                        ht.Add(cpdomainString, count);
                    }
                }
            }

            foreach (DictionaryEntry de in ht)
            {
                string oneResult = "";
                oneResult = de.Value + " " + de.Key;
                result.Add(oneResult);
            }

            return result;
        }
    }
}
