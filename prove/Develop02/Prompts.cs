public class Prompt
{
static string[] _prompts =
    {
        "What is one thing you would change about today?",
        "What is one thing that made you laugh today?",
        "Did you learn anything new today?",
        "What five words best describe your day?",
        "Did you daydream at all today? What about?",
        "Did you feel the Spirit today? What did it teach you?"
    };

// chooses random prompt from _prompts
static Random rnd = new Random();
static int index = rnd.Next(_prompts.Length);
string _prompt = ((string)_prompts[index]);
public Prompt()
{
}

public string DisplayPrompt()
{
    return _prompt;
}
}