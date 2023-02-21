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
