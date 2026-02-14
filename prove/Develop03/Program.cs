using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found!");
            return;
        }

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // hides 3 random words each time
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filePath)) return scriptures;

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length < 4) continue;

            string book = parts[0];
            if (!int.TryParse(parts[1], out int startVerse)) continue;

            Reference reference;
            string text;
            if (parts[2].Contains("-"))
            {
                var verseRange = parts[2].Split('-');
                if (verseRange.Length == 2 && int.TryParse(verseRange[1], out int endVerse))
                    reference = new Reference(book, startVerse, endVerse);
                else
                    reference = new Reference(book, startVerse);
            }
            else if (int.TryParse(parts[2], out int singleEndVerse))
                reference = new Reference(book, startVerse, singleEndVerse);
            else
                reference = new Reference(book, startVerse);

            text = parts[3];
            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}