using System.Diagnostics.Tracing;
using System.Reflection;

public class Journal
{
    public List<Entry> _entries;
    public string _writtenEntry;
    
    public void AddEntry(Entry newEntry)
    {
        Journal e1 = new Journal();
        //string _entryText = e1;

        List<Journal> _entries = new List<Journal>();
        //_entries.Add(_writtenEntry);
        //foreach (Journal e in );
        //{
        //    Console.WriteLine();
        //}
    

        
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {
        
    }
}