public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        //print the date and time
        DateTime _date = DateTime.Now;

        Console.WriteLine($"Date and time: {_date}");
        
        //create an instance of Promptgenerator
        PromptGenerator promptObject = new PromptGenerator();
        //call the GetRandomPrompt() method
        _promptText = promptObject.GetRandomPrompt();
        //Have the user enter what they want in their journal
        Console.WriteLine($"{_promptText} ");
        //Have the user enter what they want in their journal
        _entryText = Console.ReadLine();
        //Create an instance of Journal
        Journal jourObject = new Journal();
        //Call the AddEntry() method
        Entry entryObject = new Entry();
        jourObject.AddEntry(entryObject);

    }
}