using System;

namespace Exercise_1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let’s combine everything you know so far. Create program that asks the user for a string, an integer, a double and a boolean and prints them as following.
            string string1 = "This a masterpiece!";
            int integer = 42;
            double double1 = 3.1415;
            bool boolean = true;

            Console.WriteLine("Give a string: ");
            Console.WriteLine("> " + string1);
            Console.WriteLine("Give an integer: ");
            Console.WriteLine("> " + integer);
            Console.WriteLine("Give a double: ");
            Console.WriteLine("> " + double1);
            Console.WriteLine("Give a boolean: ");
            Console.WriteLine("> " + boolean);
            Console.WriteLine("Your string: " + string1);
            Console.WriteLine("Your integer: " + integer);
            Console.WriteLine("Your double: " + double1);
            Console.WriteLine("Your boolean: " + boolean);
        }
    }
}
