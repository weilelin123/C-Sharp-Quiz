using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

//Write a program to ask the user if they qualified to sign in.
// 

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pleast enter your name: ");
        var name = Console.ReadLine();
        if (name == "")
        {
            Console.WriteLine("You did not enter your name!");
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }


        //Ask the user their age
        Console.WriteLine("Please enter your age: ");
        var age = Convert.ToInt32(Console.ReadLine());

        if(age >= 18 && age <= 100)
        {
            Console.WriteLine("you are sign up.");
        }
        else if (age <= 0)
        {
            Console.WriteLine("you are not bron yet.");
        }
        else if (age <= 18)
        {
            Console.WriteLine("you are too young to sign up.");
        }
        else
        {
            Console.WriteLine("you are too old to sign up");
        }
            

        Console.ReadKey();

        System.Environment.Exit(0);
    }
}