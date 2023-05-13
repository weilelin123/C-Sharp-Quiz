using System;
using System.Collections.Generic;

/*
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.
*/

namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 8, 1, 2, 2, 3 };
            
            var list = new List<int>();
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < num)
                    {
                        sum++;
                    }
                }
                list.Add(sum);
                sum = 0;
            }
            Console.WriteLine(list.ToArray());

            Console.ReadKey();
        }

       
    }
}