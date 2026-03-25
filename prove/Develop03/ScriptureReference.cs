public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Populate scripture reference with more than one verse
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

        _endVerse = endVerse;
    }

    // Populate scripture reference with one verse
    public ScriptureReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

        _endVerse = startVerse;
    }

    // Return scripture reference in a string
    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}