using System;
using System.ComponentModel;
using System.Collections.Generic;

/// <summary>
/// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
/// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
/// any duplicates. If so, display "Duplicate" on the console./// 
/// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
            Console.WriteLine("Duplicate");

            Console.ReadKey();
        }
    }
}