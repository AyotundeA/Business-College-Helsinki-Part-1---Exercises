using System;
using System.Text;

namespace Exercise_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks user for a string.After the user has given the string the program will print the given line 3 times.Example output with Hello as input.
            Console.WriteLine("Enter a string:");
            string userString = Console.ReadLine();

            string str = new StringBuilder(userString.Length * 3).Insert(0, "\n" + userString , 3).ToString();
            Console.WriteLine("Your string input is: ");
            Console.WriteLine(str);
        }
    }
}
