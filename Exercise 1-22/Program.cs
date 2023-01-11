using System;
using System.Linq;

namespace Exercise_1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which asks the user for three integers and calculates their average as a double.

            var arr = new int[] { 3, 2, 1 };
            double avg = Queryable.Average(arr.AsQueryable());
            int number1 = 3;
            int number2 = 2;
            int number3 = 1;

            Console.WriteLine("Give the first number!");
            Console.WriteLine("> " + number1);
            Console.WriteLine("Give the second number!");
            Console.WriteLine("> " + number2);
            Console.WriteLine("Give the third number!");
            Console.WriteLine("> " + number3);
            Console.WriteLine("Average = " + avg);
        }
    }
}
