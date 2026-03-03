using System;
class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            DisplayMenu();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Pause();
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflection Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Start Gratitude Activity");
        Console.WriteLine("  5. Quit");
        Console.WriteLine();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}