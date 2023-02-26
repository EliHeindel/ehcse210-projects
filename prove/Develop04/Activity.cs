using System;

namespace MindfulActivities
{
    abstract class Activity
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
            Console.WriteLine("\n" + name);
            Console.WriteLine(description);

            while (true)
            {
                Console.Write("\nEnter the duration in seconds (minimum 10 seconds): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out duration) && duration >= 10)
                {
                    break;
                }
            }

            Console.WriteLine("\nGet ready to begin in:");
            CountDown(3);

            RunActivity();

            Console.WriteLine("\nGreat job! You have completed the " + name + " activity for " + duration + " seconds.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void CountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Go!");
        }

        protected abstract void RunActivity();
    }
}
