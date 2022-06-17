﻿using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O(inputArray.Length) * O(inputArray.Length) * O(inputArray.Length) * O(1) * O(1) * O(1) = O(inputArray.Length^3) или O(n^3)
            // ОТВЕТ:  O(n^3)
        }


        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
    }
}
