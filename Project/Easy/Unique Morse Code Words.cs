using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    public class Unique_Morse_Code_Words
    {
        /// <summary>
        /// 804. Unique Morse Code Words
        /// International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.
        /// 
        /// Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. For example, "cab" can be written as "-.-.-....-", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.
        /// Return the number of different transformations among all words we have.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int UniqueMorseRepresentations(string[] words)
        {
            Hashtable ht = morseTable();
            HashSet<string> reusltByHashSet = new HashSet<string>();

            foreach (var word in words.ToList())
            {
                reusltByHashSet.Add(tranformMorse(word, ht));
            }

            return reusltByHashSet.Count;
        }

        private static Hashtable morseTable()
        {
            Hashtable ht = new Hashtable();
            var morseWords = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            for (int i = 0; i <= 25; i++)
            {
                ht.Add(Convert.ToChar(97 + i).ToString(), morseWords[i]);
            }

            return ht;
        }

        private static string tranformMorse(string word, Hashtable ht)
        {
            List<string> wordList = word.Select(c => c.ToString()).ToList();
            string reuslt = "";

            foreach (var wordOne in wordList)
            {
                reuslt = reuslt + (string)ht[wordOne];
            }

            return reuslt;
        }
    }
}
