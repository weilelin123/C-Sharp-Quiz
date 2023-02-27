using System;
using System.ComponentModel;
using System.Collections.Generic;

/// <summary>
/// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
/// include duplicates. Display the unique numbers that the user has entered.
/// /// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
                Console.ReadKey();
        }
    }
}