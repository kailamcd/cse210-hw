public class Activity
{
    private string _startMessage = "Welcome. Get comfortable, and let's start this activity.";
    private string _finishMessage;
    private string _timeInput;
    private int _intTimeInput;

    public Activity(string timeInput) {
        _timeInput = timeInput;
    }

    public int GetIntTime(string timeInput) {
        _intTimeInput = int.Parse(timeInput);
    }
}