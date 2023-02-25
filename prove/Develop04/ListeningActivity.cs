using System

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Starting in...");
        Countdown(5);
        Console.WriteLine("Begin listing...");
        int count = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
            {
                break;
            }
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}
