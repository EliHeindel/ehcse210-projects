using System;

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

    protected void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{i} ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r   ");
        }
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name} activity.");
        Console.WriteLine(description);

        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin.");
        Pause(3);

        RunActivity();

        Console.WriteLine($"Good job! You completed the {name} activity for {duration} seconds.");
        Pause(3);
    }

    protected abstract void RunActivity();
}
