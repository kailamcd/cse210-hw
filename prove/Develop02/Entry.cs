public class Entry
{
    public string _prompt = "";
    public string _entry = "";
    public string _date = "";
    public Entry()
    {
    }
    public void DisplayEntryDetails()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");
    }

    // public string EntryString()
    // {
    //     string _fullEntry = Console.WriteLine($"{_date} , {_prompt} , {_entry}");
    //     return _fullEntry;
    // }
}