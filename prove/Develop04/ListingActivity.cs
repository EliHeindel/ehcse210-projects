using System;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void RunActivity()
    {
        int promptIndex = new Random().Next(prompts.Length);
        Console.WriteLine("Prompt: " + prompts[promptIndex]);
        Pause(5);
        Console.WriteLine("Begin listing...");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item)) continue;
            count++;
        }
        Console.WriteLine("You listed " + count + " items.");
    }
}
