using System;
public class Video
{
  private string _title;
  private string _author;
  private string _length;
  private List<Comment> _comments;


  public Video(string title, string author, string length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
  }

  public void AddComment(string name, string text)
  {
    Comment newComment = new Comment(name, text);
    _comments.Add(newComment);
  }

  private int GetNoOfComments()
  {
    return _comments.Count;
  }

  public void Display()
  {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length}");
    Console.WriteLine($"Number of Comments: {GetNoOfComments()}");
    Console.WriteLine($"Comments:");

    foreach (Comment comment in _comments)
    {
      Console.WriteLine(comment.Display());
    }
  }
}