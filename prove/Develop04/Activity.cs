public class Activity
{
    private string _startMessage = "Welcome. Get comfortable, and let's start your";
    private string _finishMessage = "Well done. Come back any time to";
    private int _intTimeInput;
    private string _fancy = ".~'`*`'~..~'`*`'~..~'`*`'~.";

    public Activity() {
        // _timeInput = timeInput;
    }


    public int GetIntTime(string activityName) {
        Console.WriteLine($"Enter how long, in seconds, you'd like to do your {activityName}.");
        string timeInput = Console.ReadLine();
        _intTimeInput = int.Parse(timeInput);
        return _intTimeInput;
    }

    public string GetStartMessage(string activityName, int time) {
        string startMessage = $"{_startMessage} {time} second {activityName}.";
        return startMessage;
    }

    public void GetFinishMessage(string activityVerb, string finishMessage="Well done. Come back any time to") {
        Pause();
        _finishMessage = finishMessage;
        Console.WriteLine($"{_finishMessage} {activityVerb}.\nPress any key to continue.");
        Console.ReadKey(true);
        Console.Clear();
    }

    public void ElipsesAnimation() {
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
    }



    public void Pause() {
        Console.CursorVisible = false;
        string fancy = _fancy;
        for (int i = 0; i < fancy.Length; i++)
        {
            Console.Write(fancy[i]);
            Thread.Sleep(100);
        }
        Console.CursorVisible = true;
        Console.WriteLine("");

    }
}