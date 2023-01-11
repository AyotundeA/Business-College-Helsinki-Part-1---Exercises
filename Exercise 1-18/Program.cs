using System;

namespace Exercise_1_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expand a little on the previous exercise. Now create a program which asks for three integers and calculates their sum.
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
