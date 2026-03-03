using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What is something small that made you smile recently?",
        "Who is someone you are grateful for today?",
        "What is a challenge that has helped you grow?",
        "What is something in nature you are thankful for?",
        "What is a talent or ability you are grateful to have?"
    };

    private Random _random = new Random();

    public GratitudeActivity()
        : base("Gratitude",
        "This activity will help you focus on the blessings in your life by guiding you to write things you are grateful for.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\nTake a moment to think deeply about each prompt.");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"\n{prompt}");
            Console.Write("> ");
            responses.Add(Console.ReadLine());

            ShowSpinner(3);
        }

        Console.WriteLine($"\nYou recorded {responses.Count} things you are grateful for.");
        EndMessage();
    }
}