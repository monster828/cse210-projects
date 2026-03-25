using System;
public class Scripture
{
    private ScriptureReference _reference;

    // Array of all of the words
    private Word[] _scriptureWords;

    // List of all the shown words
    private List<Word> _shownWords;

    // Creating scripture
    public Scripture(ScriptureReference scriptureReference, string text)
    {
        // Set reference to assigned reference
        _reference = scriptureReference;

        // Populate scripture words with the words
        SetText(text);

        // Creating list of all the shwon words
        _shownWords = _scriptureWords.ToList();
    }

    // Get words from scripture and create array
    private void SetText(string text)
    {
        // Splite text into words 
        string[] words = text.Split();

        // Populate scripture words
        _scriptureWords = new Word[words.Length];

        // Create the words and assign them to scriptureWords
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            _scriptureWords[i] = new Word();
            _scriptureWords[i].SetWord(word);
        }
    }

    // Get the scripture text
    public string GetText()
    {
        string text = "";

        // Combine words and hidden words to get scripture
        foreach(Word word in _scriptureWords)
        {
            text += word.GetWord();
            text += " ";
        }

        return text;
    }

    // Get scripture reference
    public string GetReference()
    {
        return _reference.GetReference();
    }

    // Hide amount of words from the user
    public void HideWords(int amount)
    {
        int hiddenWords = 0;
        Random random = new Random();
        while (hiddenWords != amount)
        {
            // If now more words are shown, leave the loop
            if (!IsShownWords())
            {
                break;
            }

            // Get a shown word
            Word word = _shownWords[random.Next(0, _shownWords.Count)];

            // Double check if word is shown
            if (word.IsShown())
            {
                // Hide and remove word from shown words
                word.HideWord();
                _shownWords.Remove(word);

                hiddenWords++;
            }
        }
    }

    // Get if any remaining words shown
    public bool IsShownWords()
    {
        return _shownWords.Count != 0;
    }

    // Return scripture length
    public int ScriptureLength()
    {
        return _scriptureWords.Length;
    }
}