using System;

namespace Exercise_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character: ");
            string userString = Console.ReadLine();
            Console.WriteLine("Give the character a profession: ");
            string userString2 = Console.ReadLine();
            Console.WriteLine("Here is the story: ");
            Console.WriteLine("Once upon a time there was a " + userString2 + " called " + userString);
            Console.WriteLine("On her way to work, " + userString + " often pondered what being " + userString2 + " meant to them.");
            Console.WriteLine("When you work as a " + userString2 + " you meet interesting people.: ");
            Console.WriteLine(userString + " enjoys their work as " + userString2 + ", the end. ");
            
        }
    }
}
