public class Comment
{
    public string _userName;
    public string _commentText;

    public Comment()
    {
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Username: {_userName}");
        Console.WriteLine($"Comment: '{_commentText}'");
    }
}