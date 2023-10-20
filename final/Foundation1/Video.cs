using System.Transactions;

class Video {
    private string _title;
    private string _author;
    private double _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayAll(){
        Console.WriteLine("-----------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} sec");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine("-----------------");

    }

    public int GetNumberOfComments(){
        return _comments.Count;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
}