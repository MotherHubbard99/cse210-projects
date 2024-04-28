using System;

class Program
{
    static void Main(string[] args)
    {
        int numOfGuesses = 0;
        int guess = -1;

        //Guess My Number 
        //Have the computer randomly generate a magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //Tell the user that they should pick a number from 1 to 100
        Console.WriteLine ("Welcome to the Guess My Number game. ");
        Console.WriteLine ("Let's see how many guesses it takes you to find the correct number.");
        

        while (guess != magicNumber) //user has not found the correct number yet
            {
            //ask the user to gues a number
            Console.Write("Please guess any number from 1 to 100. ");
            //make sure the user input is a number and not a letter or special character
            guess = int.Parse(Console.ReadLine());
            //Keep track of the number of guesses per game
            numOfGuesses ++;

            if (guess == magicNumber) //User found the magic number
                Console.WriteLine ($"Congratulations! You have found the magic number {magicNumber} in {numOfGuesses} tries! ");
            else if (guess < magicNumber) //User needs to guess higher
                Console.WriteLine ($"The magic number is higher than your guess of {guess}.  Please guess a higher number. ");
            else                    //User needs a lower guess
                Console.WriteLine ($"The magic number is lower than your guess of {guess}.  Please guess a lower number. ");
            }

    }
}