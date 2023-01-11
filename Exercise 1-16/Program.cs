using System;

namespace Exercise_1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which asks user for amount of days and prints the total amount of seconds for that amount of days.

            int days = 2;
            int days2 = 7;
            int seconds = 86400;
            int totalnumber = days * seconds;
            int totalnumber2 = days2 * seconds;

            Console.WriteLine("How many days?");
            Console.WriteLine("> " + days);
            Console.WriteLine(totalnumber);
            Console.WriteLine("How many days?");
            Console.WriteLine("> " + days2);
            Console.WriteLine(totalnumber2);

        }
    }
}
