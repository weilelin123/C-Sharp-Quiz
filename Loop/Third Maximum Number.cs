using System;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

//Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

//Example 1:

//Input: nums = [3, 2, 1]
//Output: 1
//Explanation:
//The first distinct maximum is 3.
//The second distinct maximum is 2.
//The third distinct maximum is 1.

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 2, 1 };
            Array.Sort(nums); 
            var value = nums.Length - 1;
            var count = 0;
            var maxValue = nums[value];

            while(value > -1)  
            {
                if (nums[value] < maxValue)
                {
                    maxValue = nums[value];
                    count++;
                }
                if (count == 2)
                    break;
                value--;
            }
            if ( count < 2)
            {
                maxValue = nums[nums.Length - 1];
            }

            Console.WriteLine(maxValue);

            Console.ReadKey();
        }
    }
}
