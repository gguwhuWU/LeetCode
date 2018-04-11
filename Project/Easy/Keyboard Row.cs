using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 500. Keyboard Row
    /// Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
    /// Input: ["Hello", "Alaska", "Dad", "Peace"]
    /// Output: ["Alaska", "Dad"]
    /// You may use one character in the keyboard more than once.
    /// You may assume the input string will only contain letters of alphabet.
    /// </summary>
    public class Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            List<string> result = new List<string>();
            List<string> keyboardRow1 = new List<string> { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p" };
            List<string> keyboardRow2 = new List<string> { "a", "s", "d", "f", "g", "h", "j", "k", "l" };
            List<string> keyboardRow3 = new List<string> { "z", "x", "c", "v", "b", "n", "m" };

            foreach (var word in words)
            {
                var wordList = word.Select(c => c.ToString()).ToList();
                string oneWord = wordList.First().ToLower();
                int lineNumber = 0;

                if (keyboardRow1.Contains(oneWord))
                {
                    lineNumber = 1;
                }
                else if (keyboardRow2.Contains(oneWord))
                {
                    lineNumber = 2;
                }
                else
                {
                    lineNumber = 3;
                }

                bool isLine = true;

                switch (lineNumber)
                {
                    case 1:
                        {
                            for (int i = 1; i < wordList.Count; i++)
                            {
                                if (!keyboardRow1.Contains(wordList[i].ToLower()))
                                {
                                    isLine = false;
                                    break;
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            for (int i = 1; i < wordList.Count; i++)
                            {
                                if (!keyboardRow2.Contains(wordList[i].ToLower()))
                                {
                                    isLine = false;
                                    break;
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            for (int i = 1; i < wordList.Count; i++)
                            {
                                if (!keyboardRow3.Contains(wordList[i].ToLower()))
                                {
                                    isLine = false;
                                    break;
                                }
                            }

                            break;
                        }
                }

                if (isLine)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }
    }
}
