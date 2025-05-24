using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words = new List<Word>();


  public Scripture(Reference reference, String text)
  {
    _reference = reference;
    String[] words = text.Split();

    foreach (string word in words)
    {
      Word newWord = new Word(word);
      _words.Add(newWord);
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    if (!_words[numberToHide].IsHidden())
    {
        _words[numberToHide].Hide();
    }
  }

  public void ShowRandomWords(int numberToHide)
  {
    if (_words[numberToHide].IsHidden())
    {
        _words[numberToHide].Show();
    }
  }

  public string GetDisplayText()
  {
    string reference = _reference.GetDisplayText();
    string scripture = "";

    foreach (Word word in _words)
    {
      scripture += $"{word.GetDisplayText()} ";
    }

    return $"{reference} {scripture}";
  }

  public bool IsCompletelyHidden()
  {
    bool isCompletelyHidden = _words.All(word => word.IsHidden());

    return isCompletelyHidden;
  }

  public int GetNumberOfWords()
  {
    return _words.Count;
  }
}