using System;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Schema;

/* 1456. Maximum Number of Vowels in a Substring of Given Length
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

 

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.

*/
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "abciiidef";
            int k = 3;
            int maxVowels = 0;
            int currentVowels = 0;
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for(int i = 0; i < s.Length; i ++)
            {
                // Add current character to the current substring
                if (vowels.Contains(s[i]))
                {
                    currentVowels++;
                }

                // Remove character that is outside the current substring
                if (i >= k && vowels.Contains(s[i - k]))
                {
                    currentVowels--;
                }
                
                // Update maxVowels if the current substring has more vowels
                if(i >= k -1 && currentVowels > maxVowels)
                {
                    maxVowels = currentVowels;
                }
            }

            Console.WriteLine(maxVowels);

            Console.ReadKey();
        }
    }
}


