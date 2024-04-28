using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        bool pass = false;
        string sign = "";

        //What is your leyter grade?
        //User enters their grade percentage
        Console.Write("What is your current grade percentage for this class? ");
            string userPercentage = Console.ReadLine();
            int percent = int.Parse(userPercentage);
            //Let's figure out the letter grade for the current percentage
            if (percent >= 90)
            {
                letterGrade = "A";
                pass = true;
            }
            else if (percent >= 80)
            {
                letterGrade = "B";
                pass = true;
            }
            else if (percent >= 70)
            {
                letterGrade = "C";
                pass = true;
            }
            else if (percent >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
        //Determine whether the grade is a +, - or straight letter
        //int divTen = percent % 10;
        //if (divTen >= 7)
        //{
        //    sign = "+";
        //}
        //else if (divTen < 3)
        //{
        //    sign = "-";
        //}
        Console.WriteLine ($"Your current letter grade is a/an {letterGrade}{sign}.");
        if (pass == true)
            Console.WriteLine ("Congratulation on passing the class! ");
        else
            Console.WriteLine ("Darn! You got this next time! ");  
    }

}