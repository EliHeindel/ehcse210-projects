using System;
using System.Linq;

class Scripture
{
    private List<Word> words;
    private int nextWordIndex;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string Reference { get; }

    public bool IsFullyHidden => nextWordIndex >= words.Count;

    public string GetHiddenText() => string.Join(" ", words.Select(w => w.IsHidden ? "_" : w.Value));

    public void HideNextWord()
    {
        if (!IsFullyHidden)
        {
            words[nextWordIndex].Hide();
            nextWordIndex++;
        }
    }
}
