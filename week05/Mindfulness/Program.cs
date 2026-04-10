/*
Eros Baez
I implemented a real spinner and countdown.
I used DateTime for accurate timing.
I avoided repeating prompts and questions by shuffling lists.
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
            
            Console.Write("Select an activity: ");
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