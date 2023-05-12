using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

/*
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
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
                if (vowels.Contains(s[i]))
                {
                    currentVowels++;
                }

                if (i >= k && vowels.Contains(s[i - k]))
                {
                    currentVowels--;
                }

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


