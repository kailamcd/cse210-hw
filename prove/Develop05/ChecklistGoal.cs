public class ChecklistGoal : Goal
{
    private string _toDoNumString;
    private double _toDoNumDouble;

    public ChecklistGoal()
    {
    }

    public double GetToDoNumDouble(string toDoNum)
    {
        _toDoNumDouble = double.Parse(toDoNum);
        return _toDoNumDouble;
    }

    public override string MakeGoalString(string name, string description, string difficulty, string toDoNum = "1", string goalType = "Simple Goal",  string isComplete = "false")
    {
        string goalString = $"{name}:, {description}, ({goalType}), {toDoNum}, {difficulty}";
        return goalString;
    }

    public override void ReceiveNewGoal()
    {
        Console.WriteLine("What is the name of this goal?");
        string name = Console.ReadLine();
        // base._goals.Add(base.GetName(name));

        Console.WriteLine("Please write a brief description of your goal: ");
        string description = Console.ReadLine(); 
        // base._goals.Add(base.GetName(description));
        // base._goals.Add($"{name}:, {description} ");

        Console.WriteLine("How many times would you like to complete this task before your goal is complete? ");
        _toDoNumString = Console.ReadLine();
        Points points = new Points();
        string difficulty = points.HowManyPoints();
        base.AddGoalToList(MakeGoalString(name, description, difficulty, _toDoNumString, "Checklist Goal"));

    }
}