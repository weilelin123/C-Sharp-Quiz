using System;
using System.Collections.Generic;

/* This is a question from LeetCode #14. Longest Common Prefix
    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        string prefix = strs[0];
        for (int i=1; i<strs.Length; i++)
        {
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix[..^1];
                if (string.IsNullOrEmpty(prefix)) return "";
            }
        }
        return prefix;
    }
}