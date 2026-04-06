/*
Eros Baez
I put a spinner and a count down.
The variables in Activity are private.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();

            else if (choice == "2")
                new ReflectionActivity().Run();

            else if (choice == "3")
                new ListingActivity().Run();
        }
    }
}