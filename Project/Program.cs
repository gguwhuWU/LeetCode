using LeetCode.Easy;
using LeetCode.Medium;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counting_Bits method = new Counting_Bits();
            //Console.WriteLine(method.CountBits(5));
            Queue_Reconstruction_by_Height method = new Queue_Reconstruction_by_Height();

            int[,] input = new int[6, 2];
            input[0, 0] = 7; input[0, 1] = 0;input[1, 0] = 4; input[1, 1] = 4;
            input[2, 0] = 7; input[2, 1] = 1;input[3, 0] = 5; input[3, 1] = 0;
            input[4, 0] = 6; input[4, 1] = 1;input[5, 0] = 5; input[5, 1] = 2;

            Console.WriteLine(method.ReconstructQueue(input));

            Console.ReadLine();
        }
    }
}
