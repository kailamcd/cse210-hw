public class SimpleGoal : Goal
{
    private string toDoNum = "1";
    

    public SimpleGoal()
    {
    }

    public override string MakeGoalString(string name, string description, string difficulty, string toDoNum = "1", string goalType = "Simple Goal",  string isComplete = "false")
    {
        string goalString = $"{name}:, {description}, ({goalType}), {toDoNum}, {difficulty}";
        return goalString;
    }
    public override void ReceiveNewGoal()
    {
        string toDoNum = "1";
        Console.WriteLine("What is the name of this goal?");
        string name = Console.ReadLine();
        // base._goals.Add(base.GetName(name));

        Console.WriteLine("Please write a brief description of your goal: ");
        string description = Console.ReadLine(); 
        // base._goals.Add(base.GetName(description));
        // base._goals.Add($"{name}:, {description} ");
        Points points = new Points();
        string difficulty = points.HowManyPoints();
        base.AddGoalToList(MakeGoalString(name, description, difficulty, toDoNum));

    }
}