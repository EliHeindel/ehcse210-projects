using System;
using System.Linq;

namespace ScriptureApp
{
   class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("2 Nephi 2:27", "Men are free to choose liberty and eternal life, or to choose captivity and death.");
        var consoleManager = new ConsoleManager();
        
        while (!scripture.IsFullyHidden)
        {
            consoleManager.Clear();
            consoleManager.WriteLine(scripture.GetHiddenText());
            consoleManager.WriteLine("Press enter to reveal more words, or type quit to exit.");

            var input = consoleManager.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideNextWord();
        }

        consoleManager.Clear();
        consoleManager.WriteLine("Congratulations! You have successfully hidden all the words.");
    }
}

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

class ConsoleManager
{
    public void Clear() => Console.Clear();
    public void WriteLine(string text) => Console.WriteLine(text);
    public string ReadLine() => Console.ReadLine();
}
}
