using System.IO;
public class AccessFile

{
    protected List<string> _goals = new List<string>();
    private int _points;
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
    
    public void Load(string fileName)
    {
        int index = 0;
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {

            string[] parts = line.Split(new string[] {",", ", "}, StringSplitOptions.None);
            string name = parts[1];
            string description = parts[2];
            string goalType = parts[3];
            string numOfTimes = parts[4];
            string difficulty = parts[5];
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
            parts[5] = _diffNum.ToString();
            index += 1;

            _goals.Add($"{index}. {name} {description}{goalType}\nWorth {_diffNum} points.\n");
        }

    }
    public void ShowGoals()
    {
        Console.Clear();
        foreach (string goal in _goals)
        {
            Console.WriteLine(goal);
        }
        Console.ReadKey(true);
    }

    // public void CheckGoal()
    // {
    //     Console.WriteLine("Which goal would you like to use?");
    //     string changeGoal = Console.ReadLine();
    //     int goal = int.Parse(changeGoal);
    //     string[] lines = System.IO.File.ReadAllLines(_fileName);

    //     foreach (string goal in _goals)
    //     {
    //         string[] parts = line.Split(new string[] {",", ", "}, StringSplitOptions.None);
    //         complete = parts[0];

    //         if (goal = complete)
    //         {
                
    //         }
    //     }
    // }



    public int GetPoints()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {

            string[] parts = line.Split(new string[] {",", ", "}, StringSplitOptions.None);
            string done = parts[0];
            string difficulty = parts[5];
            if (done == "[X]")
            {
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
                _points += _diffNum;
            }
            else
            {
                _points += 0;
            }

    }
    return _points;
    }
}
