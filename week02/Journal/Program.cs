using System;
using System.Data.Common;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();

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
                entry.WriteOption();
            }    

            if (userAnswer == 2)
            {
                entry.Display();
            }

            if (userAnswer == 3)
            {
                Console.Write("What is the file name?: ");
                string fileName = Console.ReadLine();

                SaveLoad load = new SaveLoad();
                load.LoadFile(fileName);
                entry.copyLoad._loaded = new List<string>(load._loaded);
            }

            if (userAnswer == 4)
            {
                Console.Write("What is the file name): ");
                string fileName = Console.ReadLine();

                SaveLoad save = new SaveLoad();
                foreach (string i in entry.copySave)
                {
                    save._toSave.Add(i);
                }
                save.SaveFile(fileName);
            }
            
            if (userAnswer == 5)
            {
                Console.WriteLine("Thanks for your time, see you soon!");
            }
        }
    }


}