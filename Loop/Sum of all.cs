using System;
using System.ComponentModel;

/// <summary>
/// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
/// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
/// /// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);

            Console.ReadKey();
        }
    }
}