using System;
using System.Collections.Generic;
using System.Globalization;

/*This is a question from LeetCode # 977.Squares of a Sorted Array
 * Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
 */
namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { -4, -1, 0, 3, 10 }; 

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            

            Console.ReadKey();
        }
    }
}