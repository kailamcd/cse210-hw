public class EternalGoal : Goal
{

    private double _toDoNumDouble = double.PositiveInfinity;

    public EternalGoal()
    {
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

        Console.WriteLine("Please write a brief description of your goal: ");
        string description = Console.ReadLine(); 
        Points points = new Points();
        string difficulty = points.HowManyPoints();
        base.AddGoalToList(MakeGoalString(name, description, difficulty));

    }
}