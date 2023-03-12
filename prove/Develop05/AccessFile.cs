using System.IO;
public class AccessFile

{
    protected List<string> _goals = new List<string>();
    private string _fileName;
    int _diffNum;
    public AccessFile()
    {
    }
    
    public string GetFileName(string fileName)
    {
        _fileName = $"{fileName}.txt";
        return _fileName;
    }

    public void CreateFile(string _fileName)
    {
        string path = @$"{_fileName}";
        using (FileStream fs = File.Create(path));
    }

    public void Save(List<string> goalsList)
    {
        using (StreamWriter sw = new StreamWriter(_fileName, true))
        {
            foreach (string goal in goalsList)
            {
                sw.WriteLine(goal);

            }
            goalsList.Clear();
        }
    }
    
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] {",", ", "}, StringSplitOptions.None);
            string name = parts[0];
            string description = parts[1];
            string goalType = parts[2];
            string difficulty = parts[3];
            if (difficulty == "e")
            {
                _diffNum = 10;
            }
            else if (difficulty == "m")
            {
                _diffNum = 25;
            }
            else if (difficulty == "d")
            {
                _diffNum = 50;
            }
            else if (difficulty == "x")
            {
                _diffNum = 100;
            }
            string toDoNum = parts[4];
            Console.WriteLine($"{name}{description}{goalType}\nWorth {_diffNum} points.\n");
        }

    }
}