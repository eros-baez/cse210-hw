/*
Name: Eros Baez

I added timestamps to each journal entry to track when they were written.
I also implemented file saving and loading with user feedback messages.
Additionally, I structured the program using separate Journal and Entry classes
to better organize the data and follow object-oriented principles.
*/



using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompts prompts = new Prompts();

        int userAnswer = -1;
        while (userAnswer != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");

            Console.Write("Choose a option: ");
            string userString = Console.ReadLine();
            userAnswer = int.Parse(userString);

            if (userAnswer == 1)
            {
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Write something: ");
                string text = Console.ReadLine();

                Entry entry = new Entry(prompt, text);
                journal.AddEntry(entry);
            }    

            else if (userAnswer == 2)
            {
                journal.Display();
            }

            else if (userAnswer == 3)
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine();

                journal.Load(fileName);
            }

            else if (userAnswer == 4)
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine();

                journal.Save(fileName);
            }
            
            else if (userAnswer == 5)
            {
                Console.WriteLine("Thanks for your time, see you soon!");
            }
        }
    }


}