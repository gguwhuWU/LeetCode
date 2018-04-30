using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /// <summary>
    /// 406. Queue Reconstruction by Height
    /// Suppose you have a random list of people standing in a queue. Each person is described by a pair of integers (h, k), where h is the height of the person and k is the number of people in front of this person who have a height greater than or equal to h. Write an algorithm to reconstruct the queue.
    /// Note:
    /// The number of people is less than 1,100.
    /// Example
    /// Input:
    /// [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
    /// Output:
    /// [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]
    /// 
    /// Input code Example
    /// int[,] input = new int[6, 2];
    /// input[0, 0] = 7; input[0, 1] = 0;input[1, 0] = 4; input[1, 1] = 4;
    /// input[2, 0] = 7; input[2, 1] = 1;input[3, 0] = 5; input[3, 1] = 0;
    /// input[4, 0] = 6; input[4, 1] = 1;input[5, 0] = 5; input[5, 1] = 2;
    /// </summary>
    public class Queue_Reconstruction_by_Height
    {
        public int[,] ReconstructQueue(int[,] people)
        {
            int[,] result = new int[people.Length / 2, 2];

            // 1.轉換
            var resultTemp = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < people.Length / 2; i++)
            {
                resultTemp.Add(new KeyValuePair<int, int>(people[i, 0], people[i, 1]));
            }
            // 2.list by k sort , same h sort by h
            resultTemp = resultTemp.OrderBy(x => x.Value).ThenBy(x => x.Key).ToList();

            // 3.main judgment
            for (int i = 0; i < resultTemp.Count; i++)
            {
                int target_h = resultTemp[i].Key;
                int target_k = resultTemp[i].Value;

                //只看當前這筆的前面幾筆 (例如 現在是 第3筆 只看1.2筆)
                for (int j = 0; j < i; j++)
                {
                    // 比大小
                    if (resultTemp[j].Key.CompareTo(target_h) >= 0)
                    {
                        target_k--;

                        // 超過 K 條件數量
                        if (target_k == -1)
                        {
                            //替換 位置
                            resultTemp.Insert(j, resultTemp[i]);
                            resultTemp.RemoveAt(i + 1);
                            break;
                        }
                    }
                }
            }

            // 4.轉換
            for (int i = 0; i < people.Length / 2; i++)
            {
                result[i, 0] = resultTemp[i].Key;
                result[i, 1] = resultTemp[i].Value;
            }

            return result;
        }
    }
}
