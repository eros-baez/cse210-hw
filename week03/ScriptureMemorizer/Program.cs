/*
Name: Eros Baez

I implemented multiple scriptures and randomly select one at the start of the program.
I also ensured that words are hidden without repetition and used Console.Clear()
to improve readability and user experience.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded"),

            new Scripture(new Reference("3 Nephi", 22, 13),
            "And all thy children shall be taught of the Lord and great shall be the peace of thy children")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("Press Enter or type quit: ");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
        }
    }
}