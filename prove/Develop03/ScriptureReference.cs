public class ScriptureReference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    // Populate scripture reference with more than one verse
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;

        this.endVerse = endVerse;
    }

    // Populate scripture reference with one verse
    public ScriptureReference(string book, int chapter, int startVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;

        endVerse = startVerse;
    }

    // Return scripture reference in a string
    public string GetReference()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}