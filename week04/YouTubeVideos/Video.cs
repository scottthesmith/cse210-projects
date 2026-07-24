public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}");

        Console.WriteLine($"Number of comments: {GetCommentCount()}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentInfo();
        }

    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
}
