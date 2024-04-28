using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        int sum = 0;

        //create a list object holder
        List<int> numbers = new List<int>();

        //Go into this until the user enters a zer
        while (userInput != 0)
        {
            //Ask user to enter a list of numbers;
            Console.WriteLine("Enter a list of numbers. Type 0 (zero) when finished. ");
            userInput = int.Parse(Console.ReadLine());
            //make sure user didn't enter a zero before adding number to list
            if (userInput != 0)
                numbers.Add(userInput);
           
        }
        //Compute the sum of the list
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine ($"The sum of the numbers in your list is {sum}. ");

        //Compute the average of the list of numbers
        //Need to make sun a float so we will have a decimal, if needed
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine ($"The average number in your list is {average}. ");

        //Find the largest number in the list
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                //if the number is larger than max, then set new number as max
                max = number;
            }
        }
        Console.WriteLine($"The largest number in the list is: {max}. ");

    }
}