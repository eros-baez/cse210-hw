using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int finishList = -1;
        while (finishList != 0)
        {
            Console.Write("Please enter a number to the list, 0 to finish: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
            finishList = number;        
        }

        int sum = 0;
        double average = 0;

        if (numbers.Count > 0)
        {
            int largest = numbers[0];

            foreach (int i in numbers)
            {
                sum += i;

                if (i > largest)
                {
                    largest = i;
                }
            }

            average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }




        
    }
}