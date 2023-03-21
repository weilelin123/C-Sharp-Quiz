using System;

/* This question is from LeetCode # 448.Find All Numbers Disappeared in an Array
    Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range
     [1, n] that do not appear in nums.
*/

namespace MyApp 
{
    public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        IList<int> result = new List<int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }
        
        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] > 0) 
            {
                result.Add(i + 1);
            }
        }
        return result;
    }
}
}