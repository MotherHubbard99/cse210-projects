using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user what they would like to do
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        Console.Write("> ");
        string promptGen = Console.ReadLine();
        
        if (promptGen == "1")
            {
               PromptGenerator myPrompt = new PromptGenerator();
            }
        else if (promptGen == "2")
            {

            }
        else if (promptGen == "3")
            {
                
            }
        else if (promptGen == "4")
            {

            }
        else if (promptGen == "5")
            {

            }
        else
            Console.WriteLine("Your selection needs to be 1, 2, 3, 4, or 5.  Please try again. ");
        


    }
}