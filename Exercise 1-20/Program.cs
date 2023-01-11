using System;

namespace Exercise_1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which asks the user for two integers and multiplies them with each other.
            int number1 = 3;
            int number2 = 2;
            int totalnumber = number1 * number2;

            int number3 = 50;
            int number4 = -2;
            int totalnumber2 = number3 * number4;

            Console.WriteLine("Give the first number!");
            Console.WriteLine("> " + number1);
            Console.WriteLine("Give the second number!");
            Console.WriteLine("> " + number2);
            Console.WriteLine(number1 + " + " + number2 + " + " + totalnumber);
            Console.WriteLine("Give the first number!");
            Console.WriteLine("> " + number3);
            Console.WriteLine("Give the second number!");
            Console.WriteLine("> " + number4);
            Console.WriteLine(number3 + " + " + number4 + " + " + totalnumber2);
        }
    }
}
