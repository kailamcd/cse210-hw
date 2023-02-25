using System.Diagnostics;
public class BreathingActivity : Activity
{
    private string _inhale = "slowly breathe in";
    private string _exhale = "and breathe out";
    private string _breathDescription = "This activity will help you control your breathing. Controlling your breath can calm anxiety, help you think more clearly, and increase your access to the Spirit.\n\nPress any key to start.";
    Stopwatch s = new Stopwatch();

    public BreathingActivity() : base() 
    {
    }

    public string GetBreathDescription() {
        string breathDescription = _breathDescription;
        return breathDescription;
    }

    public void RunBreathingActivity(int time) {
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


    }
}