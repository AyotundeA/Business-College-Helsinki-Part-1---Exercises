using System;

namespace Exercise_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user for a boolean. After user input the program will print the boolean.
            bool truth = true;
            bool truthisfalse = false;
            Console.WriteLine("Give me the truth!");
            Console.WriteLine(">" + truth);
            Console.WriteLine("True");
            Console.WriteLine("Give me the truth!");
            Console.WriteLine(">" + truthisfalse);
            Console.WriteLine("False");
        }
    }
}
