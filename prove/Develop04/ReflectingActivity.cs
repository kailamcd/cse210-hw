using System.Diagnostics;
public class ReflectingActivity : Activity
{
    static string[] _prompts = 
    {
        "Think of a time you served someone else.",
        "Think of a time you did something really difficult.",
        "Think of a time you resisted temptation.",
        "Think of a time you felt the Holy Ghost prompt you."
    };
    static string[] _questions = 
    {
        "Why was this experience meaningful to you?",
        "What was your first thought in this experience?",
        "How did you feel when you finished this experience?",
        "What do you remember most fondly about this experience?",
        "What did you learn about yourself from this experience?",
        "How have you changed because of this experience?"
    };
    private string _reflectDescription = "This activity will help you remember and learn from past experiences.\nYou'll be given a prompt to consider, followed by some questions to increase your connection to that prompt.\n\nPress any key to start.";
    Stopwatch s = new Stopwatch();
    public ReflectingActivity() : base() {

    }

    public string GetReflectionDescription() {
        string reflectDescription = _reflectDescription;
        return reflectDescription;
    }

    public void RunReflectingActivity(string activityName, int time) {
        Console.Clear();
        Console.WriteLine(base.GetStartMessage(activityName, time));
        base.Pause();
        Console.WriteLine(GetReflectionDescription());
        Console.ReadKey(true);
        Console.Clear();

        s.Start();
        Console.WriteLine(GetPrompt());
        while (s.Elapsed < TimeSpan.FromSeconds(time)) 
        {
            Console.CursorVisible = false;
            base.Pause();
            base.Pause();
            Console.WriteLine(GetQuestions());
            base.Pause();
            base.Pause();
        }
        s.Stop();
        Console.CursorVisible = true;
        base.GetFinishMessage("reflect");

    }

    public string GetPrompt() {
        var rnd = new Random();
        int index = rnd.Next(_prompts.Length);
        string _prompt = ((string)_prompts[index]);
        return _prompt;
    }

    public string GetQuestions() {
        var rnd1 = new Random();
        int index1 = rnd1.Next(_questions.Length);
        string _question = ((string)_questions[index1]);
        return _question;
    }
}