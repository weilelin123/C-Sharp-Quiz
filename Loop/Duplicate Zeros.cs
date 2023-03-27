using System;

/* This is question is form LeetCode #1089.Duplicate Zeros.

Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Example 1:
Input: arr = [1,0,2,3,0,4,5,0]
Output: [1,0,0,2,3,0,0,4]
*/

public class Solution {
    public void DuplicateZeros(int[] arr) 
    {
        
     int n = arr.Length;
     int i = 0;

    while (i < n) {
        if (arr[i] == 0) {
            
            for (int j = n - 2; j >= i; j--) {
                if (j + 1 < n) {
                    arr[j + 1] = arr[j];
                }
            }
            
            // Duplicate the zero
            if (i + 1 < n) {
                arr[i + 1] = 0;
            }
            i += 2;
        } else {
            i++;
        }
    }
  }
}