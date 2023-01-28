using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";
    public Journal()
    {
    }

    public void DisplayJournal()
    {
        Console.WriteLine($"Entries:");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }

        public void CreateFile()
    {
        //create a file using user input as name
        string path = @$"{_fileName}";
        using (FileStream fs = File.Create(path));
    }

    public void Save()
    {
        using (StreamWriter sw = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date}; {entry._prompt}; {entry._entry}");
            }

        }
    }
    
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string _date = parts[0];
            string _prompt = parts[1];
            string _entry = parts[2];
            Console.WriteLine($"{_date}");
            Console.WriteLine($"{_prompt}");
            Console.WriteLine($"{_entry}");
            Console.WriteLine("");
        }

    }
}