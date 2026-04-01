/*
Name: Eros Baez

I verified that the "_" is not repeated, and I use two different scripture.

Also I used Console.Clear() to write in the same place.
*/

using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Reference readReference = new Reference();
        List<string> reference = new List<string>(readReference._references);
        Scripture readScripture = new Scripture();
        List<string> scripture = new List<string>(readScripture._scriptures);

    
        Scripture scriptureObject = new Scripture();
        int itemNumber = scriptureObject.GetRandomItem();
    

        int counting = scripture[itemNumber].Count();


        Random random = new Random();
        

        while (counting != 0)
        {
            Console.Clear();

            string scriptureAndReference = $"{reference[itemNumber]}: {scripture[itemNumber]}";

            Console.WriteLine(scriptureAndReference);
            Console.Write("Press Enter to continue or write quite to exit: ");
            string answer = Console.ReadLine();

            

            if (answer == "quite")
            {
                break;
            }

            else
            {   
                char[] character = scripture[itemNumber].ToCharArray();
                
                List<int> validIndex = new List<int>();

                for (int i = 0 ; i < character.Length; i++)
                {
                    if (character[i] != ' ' &&  character[i] != '_')
                    {
                        validIndex.Add(i);
                    }
                }

                if (validIndex.Count > 0)
                {
                    int index = validIndex[random.Next(validIndex.Count())];
                    character[index] = '_';
                    counting --;
                }

                if (validIndex.Count == 0)
                {
                    break;
                }


                scripture[itemNumber] = new string (character);
                    
            }















































            

                
        }



    }
        
}