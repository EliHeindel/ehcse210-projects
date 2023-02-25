using System;

abstract class Activity
{
    private string name;
    private string description;
    private int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        Pause(3);
        RunActivity();
        DisplayEndingMessage();
    }

    protected abstract void RunActivity();

    private void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {name}: {description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Get ready to begin in 3 seconds...");
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed {name} for {duration} seconds.");
        Pause(3);
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
}
