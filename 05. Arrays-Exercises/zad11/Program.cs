﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool sumsEqual = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    leftSum += arr[left];
                }
                for (int right = i+1; right < arr.Length; right++)
                {
                    rightSum += arr[right];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    sumsEqual=true;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!sumsEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
