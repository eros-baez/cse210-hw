using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        string continuePlaying = "yes";

        while (continuePlaying == "yes")
            {
                Random generator = new Random();
                int magicNumber = generator.Next(1, 101);
                int guess = -1;
                int attempts = 0;


                while (guess != magicNumber)
                    {
                        Console.Write("Guess the number: ");
                        string input = Console.ReadLine();
                        guess = int.Parse(input);
                        attempts = attempts + 1;

                        if (guess > magicNumber)
                        {
                            Console.WriteLine("Lower");
                        }
                        if (guess < magicNumber)
                        {
                            Console.WriteLine("Higher");
                        }
                    }

                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You have taken {attempts} attempts ");


                Console.Write("Do you want to play again?(yes/no): ");
                continuePlaying = Console.ReadLine();
            }
         

    }
}