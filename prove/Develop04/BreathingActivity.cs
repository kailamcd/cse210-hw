using System.Diagnostics;
public class BreathingActivity : Activity
{
    private string _inhale = "slowly breathe in";
    private string _exhale = "and breathe out";
    private string _hold = "hold";
    // private string _breathDescription = 
    List<string> _breathDescriptions = new List<string>()
    {
        "This activity will help you control your breathing. Controlling your breath can calm anxiety, help you think more clearly, and increase your access to the Spirit.\n\nPress any key to start.",
        "This activity will help you find peace. Our brains are wired to believe we are in danger when we breathe quickly. By slowing our breathing, we can show our minds it is safe to be calm.\n\nPress any key to start."
    };
    Stopwatch s = new Stopwatch();

    public BreathingActivity() : base() 
    {
    }

    public string GetBreathDescription(int type) {
        string breathDescription = _breathDescriptions[type];
        return breathDescription;
    }

    public void RunBreathingActivity(string activityName, int time) {

        Console.Clear();
        Console.WriteLine(base.GetStartMessage(activityName, time));
        base.Pause();
        Console.WriteLine("Are you currently feeling anxious? y/n ");
        string answer = Console.ReadLine();
        switch (answer)
        {
            case "y":
                Console.WriteLine(GetBreathDescription(1));
                Console.ReadKey(true);
                Console.Clear();

                s.Start();

                while (s.Elapsed < TimeSpan.FromSeconds(time))
                {
                    Console.CursorVisible = false;
                    Console.Write(_inhale);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.Write(_hold);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.Write(_exhale);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.Write(_hold);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                s.Stop();

                Console.CursorVisible = true;
                base.GetFinishMessage("take a breath");
                break;

            case "n":
                Console.WriteLine(GetBreathDescription(0));
                Console.ReadKey(true);
                Console.Clear();

                s.Start();

                while (s.Elapsed < TimeSpan.FromSeconds(time))
                {
                    Console.CursorVisible = false;
                    Console.Write(_inhale);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.Write(_exhale);
                    base.ElipsesAnimation();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                s.Stop();

                Console.CursorVisible = true;
                base.GetFinishMessage("take a breath");
                break;
        }

    }
}