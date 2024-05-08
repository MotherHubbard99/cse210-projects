using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
        
        //create an instance of Promptgenerator
        //PromptGenerator promptObject = new PromptGenerator();
        //call the GetRandomPrompt() method
        //string prompt = promptObject.GetRandomPrompt();
        //Console.WriteLine($"{prompt}");
        
        //Create an instance of Journal
        //Journal jourObject = new Journal();
        

        if (promptGen == "1")
            {
                //Create an instance of Entry
                Entry entryObject = new Entry();
                //Call the AddEntry() method
                entryObject.Display();
                //Create an instance of Entry
            }

        else if (promptGen == "2")
            {
                //Call the DisplayAll() method
                //jourObject.DisplayAll();
            }
        else if (promptGen == "3")
            {
                //Call the SavetoFile() method
                //jourObject.SaveToFile("");
            }
        else if (promptGen == "4")
            {
                //Call the LoadFromFile() method
               // jourObject.LoadFromFile("");
            }
        else if (promptGen == "5")
            {

            }
        else
            Console.WriteLine("Your selection needs to be 1, 2, 3, 4, or 5.  Please try again. ");
        


    }
}