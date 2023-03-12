public abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    public static List<string> _goals = new List<string>();

    public Goal()
    {
    }

    public string GetGoalType(string goalType)
    {
        _goalType = goalType;
        return goalType;
    }

    public string GetName(string name)
    {
        _name = name;
        return _name;
    }

    public string GetDescription(string description)
    {
        _description = description;
        return _description;
    }

    public abstract void ReceiveNewGoal();

    public abstract string MakeGoalString(string name, string description, string difficulty, string toDoNum, string goalType, string isComplete);


    public void AddGoalToList(string goalString)
    {
        _goals.Add(goalString);
    }

    public void DisplayGoalList()
    {
        
        foreach (string goal in _goals)
        {
            string[] parts = goal.Split(new string[] {",", ", ","\n"}, StringSplitOptions.None);
            string name = parts[0];
            string description = parts[1];
            string goalType = parts[2];
            string difficulty = parts[3];
            string toDoNum = parts[4];
            Console.WriteLine($"{name}{description}{goalType}");
        }
    }


}