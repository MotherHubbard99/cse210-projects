using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    } 
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your user name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            //find the square root of the user's favorite number
            int squareroot = number * number;
            return squareroot;
        }
        static void DisplayResult(string name, int squared)
            {
               Console.WriteLine($"{name}, the square of your favorite number is {squared}. ");
            }
}