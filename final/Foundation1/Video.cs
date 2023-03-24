public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSec;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Time: {_lengthInSec}");
        Console.WriteLine();
        Console.WriteLine($"{NumOfComments()} Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine("------");
        }
        Console.WriteLine();
    }

    public int NumOfComments()
    {
        return _comments.Count();
    }
}