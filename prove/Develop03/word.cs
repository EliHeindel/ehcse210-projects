using System;
using System.Linq;

class Word
{
    public Word(string value)
    {
        Value = value;
    }

    public string Value { get; }
    public bool IsHidden { get; private set; }

    public void Hide()
    {
        IsHidden = true;
    }
}
