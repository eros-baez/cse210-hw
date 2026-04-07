using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        if (grade >= 93)
        {
            Console.WriteLine("Your calification is: A");
        }

        if (grade < 93 && grade >= 90)
        {
            Console.WriteLine("Your calification is: A-");
        }

        if (grade < 90 && grade >= 87)
        {
            Console.WriteLine("Your calification is: B+");
        }
        if (grade < 87 && grade >= 83)
        {
            Console.WriteLine("Your calification is: B");
        }
        if (grade < 83 && grade >= 80)
        {
            Console.WriteLine("Your calification is: B-");
        }
        if (grade < 80 && grade >= 77)
        {
            Console.WriteLine("Your calification is: C+");
        }
        if (grade < 77 && grade >= 73)
        {
            Console.WriteLine("Your calification is: C");
        }
        if (grade < 73 && grade >= 70)
        {
            Console.WriteLine("Your calification is: C-");
        }
        if (grade < 70 && grade >= 67)
        {
            Console.WriteLine("Your calification is: D+");
        }
        if (grade < 67 && grade >= 63)
        {
            Console.WriteLine("Your calification is: D");
        }
        if (grade < 63 && grade >= 60)
        {
            Console.WriteLine("Your calification is: D-");
        }
        if (grade < 60)
        {
            Console.WriteLine("Your calification is: F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Keep trying, you can do better!");
        }

    }
}