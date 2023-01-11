using System;

namespace Exercise_1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which asks the user for two integers and counts their sum. This time also print the equation to the user.
            int number1 = 3;
            int number2 = -1;
            int number3 = 2;
            int totalnumber = number1 + number2 + number3;

            Console.WriteLine("Give the first number!");
            Console.WriteLine("> " + number1);
            Console.WriteLine("Give the second number!");
            Console.WriteLine("> " + number2);
            Console.WriteLine("Give the third number!");
            Console.WriteLine("> " + number3);
            Console.WriteLine("The sum is " + totalnumber);
        }
    }
}
