using System.Dynamic;

class Video
{
    public string _title;
    public string _author;
    public int _length;

    List<Comments> _comments { get; set; }

    public Video(string title, int length, string author)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();

    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }


    public void AddComment(Comments comments)
    {
        _comments.Add(comments);
    }

    public int NumComents()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length : {_length} seconds");
        Console.WriteLine($"Author : {_author}");
        Console.WriteLine("Comments ");

        foreach (var comments in _comments)
        {
            Console.WriteLine($"- {comments._name} : {comments._text}");
        }
    }

}