using System.Diagnostics;
public class ListingActivity : Activity
{
    private string _userItem;
    private int _userListCount;
    private string _prompt;
    private string _listDescription = "This activity will help you quickly identify good things in your life.\nYou will receive a prompt. Type as many responses as you can, each followed by the 'enter' key.\n\nPress any key to start.";
    Stopwatch s = new Stopwatch();
    List<string> _prompts = new List<string>()    
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you've served?",
        "What are some things you love about yourself?",
        "What are you grateful for?"
    };
    List<string> _userList = new List<string>()
    {
    };

    public ListingActivity() : base() {

    }

    public string GetListingDescription() {
        string listDescription = _listDescription;
        return listDescription;
    }

    public void RunListingActivity(int time) {
        Console.Clear();
        _prompt = GetPrompt();
        Console.WriteLine(_prompt);
        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(time))
        {
            Console.Clear();
            Console.WriteLine(_prompt);
            Console.Write("  >");
            _userItem = Console.ReadLine();
            _userList.Add(_userItem);
        }
        s.Stop();
        Console.Clear();
        _userListCount = GetListCount();
        Console.WriteLine($"For the prompt '{_prompt}', you listed {_userListCount} answers:");
        Console.WriteLine();
        DisplayUserList();
        Console.WriteLine();
        base.GetFinishMessage("count your blessings");
    }

    public string GetPrompt() {
        var rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string _prompt = ((string)_prompts[index]);
        return _prompt;
    }

    public int GetListCount() {
        _userListCount = _userList.Count();
        return _userListCount;
    }

    public void DisplayUserList() {
        Console.Write(string.Join(", ", _userList));
    }

 
}