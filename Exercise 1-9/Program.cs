using System;

namespace Exercise_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that simulates a small conversation. The program will tell three lines and expects two user inputs.

            Console.WriteLine("Hello, how are you?");
            string userString = Console.ReadLine();
            Console.WriteLine("That's interesting, tell me more");
            string userString2 = Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");
        }
    }
}
