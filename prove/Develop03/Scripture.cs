using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    // Hides a few random words
    public void HideRandomWords(int count)
    {
        var visibleWords = Words.FindAll(w => !w.IsHidden);
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine(Reference.ToString());
        foreach (var word in Words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine("\n");
    }
}