public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _commenterName = name;
        _commentText = commentText;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"Commenter: {_commenterName} \nComment: {_commentText}");
    }

    
    
}