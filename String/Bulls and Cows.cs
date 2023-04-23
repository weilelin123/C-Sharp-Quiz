using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Sockets;

/* Leetcode #299.Bulls and Cows
 * You are playing the Bulls and Cows game with your friend.

You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:

The number of "bulls", which are digits in the guess that are in the correct position.
The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.

The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
 */
namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your secret number(4 digts): ");
            string secret = Convert.ToString(Console.ReadLine());
            Console.Write("Please enter your guess number(4 digts): ");
            string guess = Convert.ToString(Console.ReadLine());

            int bulls = 0, cows = 0;
            int[] counts = new int[10]; // counts for each digit in secret

            for (int i = 0; i < secret.Length; i++)
            {
                int s = secret[i] - '0'; // convert char to int
                int g = guess[i] - '0'; // convert char to int

                if (s == g)
                {
                    bulls++; // increment bulls if digits match
                }
                else
                {
                    if (counts[s] < 0) cows++; // if s has appeared in guess before, increment cows
                    if (counts[g] > 0) cows++; // if g has appeared in secret before, increment cows

                    counts[s]++; // increment count for s in secret
                    counts[g]--; // decrement count for g in guess
                }
            }

            Console.WriteLine(bulls + " digits in the guess that are in the correct position.");
            Console.WriteLine(cows + " digits in the guess that are in your secret number but are located in the wrong position.");
            Console.ReadKey();
        }

       
    }
}