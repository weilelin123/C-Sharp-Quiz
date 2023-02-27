using System;
using System.ComponentModel;

/// <summary>
/// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
/// is landscape or portrait.
/// </summary>

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);

            Console.ReadKey();
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}