using System;
using System.Collections.Generic;

public class Prompts
{
    public List<string> _prompts = new List<string> {@"Who was the most interesting person I interacted
     with today?", "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
     "If I had one thing I could do over today, what would it be?;"};
    
    public void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int random = randomPrompt.Next(_prompts.Count);

        string randomPhrase = _prompts [random];
        Console.WriteLine(randomPhrase);
        
    }







}