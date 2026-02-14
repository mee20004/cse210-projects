public class Reference
{
    public string BookName { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int startVerse)
    {
        BookName = book;
        StartVerse = startVerse;
        EndVerse = null;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        BookName = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{BookName} {StartVerse}-{EndVerse}" : $"{BookName} {StartVerse}";
    }
}