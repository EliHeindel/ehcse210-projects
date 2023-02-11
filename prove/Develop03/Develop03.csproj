using System;
using System.Linq;

namespace ScriptureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("2 Nephi 2:27", "And it must needs be that the devil should tempt the children of men, or they must become devilish.");

            scripture.Display();
            while (scripture.HasHiddenWords())
            {
                Console.WriteLine("Press enter to hide more words or type 'quit' to end the program: ");
                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    break;
                }
                scripture.HideWords();
                scripture.Display();
            }

            Console.WriteLine("Congratulations! You have successfully hidden all words in the scripture.");
        }
    }

    class Scripture
    {
        private string reference;
        private string text;
        private bool[] hiddenWords;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
            this.hiddenWords = Enumerable.Repeat(false, text.Split(' ').Length).ToArray();
        }

        public bool HasHiddenWords()
        {
            return this.hiddenWords.Contains(false);
        }

        public void HideWords()
        {
            Random random = new Random();
            int hiddenWordIndex = random.Next(0, this.text.Split(' ').Length);
            this.hiddenWords[hiddenWordIndex] = true;
        }

        public void Display()
        {
            Console.Clear();
            string[] words = this.text.Split(' ');
            Console.WriteLine("Scripture: " + this.reference);
            Console.WriteLine("");
            for (int i = 0; i < words.Length; i++)
            {
                if (!this.hiddenWords[i])
                {
                    Console.Write(words[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine("");
        }
    }
}
