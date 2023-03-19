using System;
using System.ComponentModel;

/// <summary>
/// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
/// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
/// display 8 on the console.
/// /// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

            Console.ReadKey();
        }
    }
}