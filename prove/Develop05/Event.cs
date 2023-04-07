using System.IO;
public class Event
{
    private string _notDone = "[ ]";
    private string _done = "[X]";
    AccessFile f = new AccessFile();
    
    public Event()
    {
    }

    public void CompleteGoal(string goalToComplete)
    {
        List<string> _goals = AccessFile.GetAllGoals();
        int complete = int.Parse(goalToComplete);
        int index = 0;
        foreach (string goal in _goals)
        {
            string[] parts = goal.Split(new string[] {","}, StringSplitOptions.None);
            string done = parts[1];
            string name = parts[2];
            string description = parts[3];
            string goalType = parts[4];
            string numOfTimes = parts[5];
            string difficulty = parts[6];
            int userIndex = complete - 1;
            if (index == userIndex)
            {
                string newGoal = $"{index+1},{_done},{name},{description},({goalType}),{numOfTimes},{difficulty}";
                f.Replace(index, newGoal);
            }
            else 
            {
                continue;
            }
            // goal[index] = Replace(goal, finishedGoal);
            index += 1;
           
        }
        Console.WriteLine(_goals);
    }

    public string CheckGoal(string part)
    {
        part = "[X]";
        return part;
    }

    // public string ReplaceGoal()
    // {
    //     oldValue = newValue;
    //     return oldValue;
    // }
    



}