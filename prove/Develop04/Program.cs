using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");

                int choice = int.Parse(Console.ReadLine());

                Activity activity;

                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    case 2:
                        activity = new ReflectionActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    case 4:
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;
                }

                activity.Start();
            }
        }
    }
}
