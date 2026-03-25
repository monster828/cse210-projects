public class Word
{
    private bool _shown = true;
    private string _word;

    // Set the word
    public void SetWord(string word)
    {
        _word = word;
    }

    // Get the word
    public string GetWord()
    {
        return _word;
    }

    // Turn word from WORD to ____ to hide it from the user
    public void HideWord()
    {
        _shown = false;
        string hidden = "";

        // Loops through and for each character in word add a _ to the hidden word
        foreach(char _ in _word)
        {
            hidden += "_";
        }
        
        // Set word to the hidden word
        _word = hidden;
    }

    // Returns if shown or not
    public bool IsShown()
    {
        return _shown;
    }
}