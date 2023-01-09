using System;

namespace Exercise_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks user for their name and greets them. Example output with Ada as input.
            //Notice the exclamation mark!

            Console.WriteLine("What is your name?");
            string userString = Console.ReadLine();
            Console.WriteLine("Hello " + userString + "!");
        }
    }
}
