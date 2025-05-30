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

  public int GetNoOfComments()
  {
    return _comments.Count;
  }

  public void Display()
  {
    string result = $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\n";
    string comments = "";

    foreach (Comment comment in _comments)
    {
      comments += comment.Display();
    }

    result += $"Comments: \n{comments}";

    Console.WriteLine(result);
  }
}