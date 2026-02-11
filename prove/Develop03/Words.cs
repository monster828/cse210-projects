public class Word
{
    private bool shown = true;
    private string word;

    // Set the word
    public void SetWord(string word)
    {
        this.word = word;
    }

    // Get the word
    public string GetWord()
    {
        return word;
    }

    // Turn word from WORD to ____ to hide it from the user
    public void HideWord()
    {
        shown = false;
        string hidden = "";

        // Loops through and for each character in word add a _ to the hidden word
        foreach(char _ in word)
        {
            hidden += "_";
        }
        
        // Set word to the hidden word
        word = hidden;
    }

    // Returns if shown or not
    public bool IsShown()
    {
        return shown;
    }
}