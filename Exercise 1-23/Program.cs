using System;

namespace Exercise_1_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 2;
            double totalnumber1 = number1 + number2;
            double totalnumber2 = number1 - number2;
            double totalnumber3 = number1 * number2;
            double totalnumber4 = number1 / number2;

            Console.WriteLine("Give the first number!");
            Console.WriteLine("> " + number1);
            Console.WriteLine("Give the second number!");
            Console.WriteLine("> " + number2);
            Console.WriteLine(number1 + " + " + number2 + " = " + totalnumber1);
            Console.WriteLine(number1 + " - " + number2 + " = " + totalnumber2);
            Console.WriteLine(number1 + " * " + number2 + " = " + totalnumber3);
            Console.WriteLine(number1 + " / " + number2 + " = " + totalnumber4);


        }
    }
}
