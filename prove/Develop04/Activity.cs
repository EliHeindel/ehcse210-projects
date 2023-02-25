using System;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string name;
        protected string description;
        protected int duration;

        public Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Start()
        {
            Console.WriteLine($"\n{name} Activity");
            Console.WriteLine(description);

            duration = GetDuration();

            Console.WriteLine($"\nPrepare to begin in 3 seconds.");
            Countdown(3);

            RunActivity();

            Console.WriteLine($"\nGood job! You have completed the {name} activity for {duration} seconds.");
            Console.WriteLine("Take some time to relax and clear your mind.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        protected int GetDuration()
        {
            Console.WriteLine("\nPlease enter the duration of the activity in seconds:");
            string input = Console.ReadLine();

            int duration;
            if (!int.TryParse(input, out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid input. Duration must be a positive integer.");
                return GetDuration();
            }

            return duration;
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}...");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Go!");
        }

        protected abstract void RunActivity();
    }
}
