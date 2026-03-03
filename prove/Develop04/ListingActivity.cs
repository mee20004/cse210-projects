using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace recently?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        StartMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}