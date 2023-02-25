using System
class ListingActivity : Activity
{
    private static Random random = new Random();

    private static List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void RunActivity()
    {
        int itemsCount = 0;
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Pause(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            itemsCount++;
        }

        Console.WriteLine($"You listed {itemsCount} items.");
    }
}
