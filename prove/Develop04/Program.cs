using System;

namespace MindfulActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mindful Activities!");

            while (true)
            {
                Console.WriteLine("\nPlease select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");

                int choice = 0;
                while (choice < 1 || choice > 4)
                {
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out choice) == false)
                    {
                        choice = 0;
                    }
                }

                if (choice == 1)
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Start();
                }
                else if (choice == 2)
                {
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Start();
                }
                else if (choice == 3)
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Start();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using Mindful Activities!");
        }
    }
}
