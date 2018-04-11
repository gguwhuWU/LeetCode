using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    /// 678. Valid Parenthesis String
    /// Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:
    /// Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    /// Any right parenthesis ')' must have a corresponding left parenthesis '('.
    /// Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    /// '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
    /// An empty string is also valid.
    /// </summary>
    public class Valid_Parenthesis_String : IValid_Parenthesis_String
    {
        public bool CheckValidString(string input)
        {
            try
            {
                var inputs = input.Split('*').ToList();

                if (inputs.Count == 1)
                {
                    return BaseValidateByOne(input);
                }

                return StartRangeValidateWithOne(inputs);
            }
            catch
            {
                return false;
            }
        }

        private static bool StartRangeValidateWithOne(List<string> inputs)
        {
            string targeRangeByHead = "";
            string targeRangeByTail = "";

            for (int i = 0; i < inputs.Count; i++)
            {
                targeRangeByHead = targeRangeByHead + inputs[i];
                int centerCountByHead = BaseValidateHaveTempByHead(targeRangeByHead, i);

                if ((centerCountByHead + i) < 0)
                {
                    return false;
                }

                int i_Tail = inputs.Count - i - 1;

                targeRangeByTail = inputs[i_Tail] + targeRangeByTail;
                int centerCountByTail = BaseValidateHaveTempByTail(targeRangeByTail, i);

                if ((centerCountByTail - i) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool StartRangeValidate(List<string> inputs)
        {
            string targeRangeByHead = "";

            for (int i = 0; i < inputs.Count; i++)
            {
                targeRangeByHead = targeRangeByHead + inputs[i];
                int centerCount = BaseValidateHaveTempByHead(targeRangeByHead, i);

                if ((centerCount + i) < 0)
                {
                    return false;
                }
            }
           
            string targeRangeByTail = "";

            for (int i = 0; i < inputs.Count; i++)
            {
                int i_Tail = inputs.Count - i - 1;

                targeRangeByTail = inputs[i_Tail] + targeRangeByTail;
                int centerCount = BaseValidateHaveTempByTail(targeRangeByTail, i);

                if ((centerCount - i) > 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        private static int BaseValidateHaveTempByHead(string input, int tempResult)
        {
            int result = 0;

            foreach (var s in input.ToList())
            {

                switch (s.ToString())
                {
                    case "(":
                        {
                            result++;
                            tempResult++;
                            break;
                        }
                    case "*":
                        {
                            tempResult++;
                            break;
                        }
                    case ")":
                        {
                            result--;
                            tempResult--;
                            break;
                        }
                }

                if (tempResult < 0)
                {
                    throw new Exception();
                }
            }

            return result;
        }

        private static int BaseValidateHaveTempByTail(string input, int tempResult)
        {
            int result = 0;
            tempResult = 0 - tempResult;

            foreach (var s in input.Reverse().ToList())
            {

                switch (s.ToString())
                {
                    case "(":
                        {
                            result++;
                            tempResult++;
                            break;
                        }
                    case "*":
                        {
                            tempResult--;
                            break;
                        }
                    case ")":
                        {
                            result--;
                            tempResult--;
                            break;
                        }
                }

                if (tempResult > 0)
                {
                    throw new Exception();
                }
            }

            return result;
        }

        private static bool BaseValidateByOne(string input)
        {
            int result = 0;

            foreach (var s in input.ToList())
            {

                switch (s.ToString())
                {
                    case "(":
                        {
                            result++;
                            break;
                        }
                    case "*":
                        {
                            break;
                        }
                    case ")":
                        {
                            result--;
                            break;
                        }
                }

                if (result < 0)
                {
                    return false;
                }
            }

            if (result == 0)
            {
                return true;
            }

            return false;
        }
    }
}
