using System;

public class Word
{
  private string _text;
  private string _originalText;
  private bool _isHidden;

  public Word(string text)
  {
    _text = text;
    _originalText = text;
  }

  public void Hide()
  {
    _text = new string('_', _text.Length);
    _isHidden = true;
  }

  public void Show()
  {
    _text = _originalText;
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    return _text;
  }
}