using System;
using System.ComponentModel;
using System.Collections.Generic;

/// <summary>
/// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
/// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
/// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
/// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

            Console.ReadKey();
        }
    }
}