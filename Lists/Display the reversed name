using System;
using System.ComponentModel;

/// <summary>
/// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
/// Display the reversed name on the console.
/// /// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

            Console.ReadKey();
        }
    }
}