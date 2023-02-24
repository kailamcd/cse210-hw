public class BreathingActivity : Activity
{
    private string _inhale;
    private string _exhale;
    private int _inhaleTime;
    private int _exhaleTime;
    private string _breathDescription = "This activity will help you control your breathing. Controlling your breath can calm anxiety, help you think more clearly, and increase your access to the Spirit.\nPress enter when you're ready to start.";

    public BreathingActivity(string breathDescription) : base(timeInput) {
        // _inhale = inhale;
        // _exhale = exhale;
        _breathDescription = breathDescription;
    }

    public string GetBreathDescription(string breathDescription) {
        _breathDescription = breathDescription;
    }
}