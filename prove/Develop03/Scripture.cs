using System;
public class Scripture
{
    private ScriptureReference reference;

    // Array of all of the words
    private Word[] scriptureWords;

    // List of all the shown words
    private List<Word> shownWords;

    // Creating scripture
    public Scripture(ScriptureReference scriptureReference, string text)
    {
        // Set reference to assigned reference
        reference = scriptureReference;

        // Populate scripture words with the words
        SetText(text);

        // Creating list of all the shwon words
        shownWords = scriptureWords.ToList();
    }

    // Get words from scripture and create array
    private void SetText(string text)
    {
        // Splite text into words 
        string[] words = text.Split();

        // Populate scripture words
        scriptureWords = new Word[words.Length];

        // Create the words and assign them to scriptureWords
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            scriptureWords[i] = new Word();
            scriptureWords[i].SetWord(word);
        }
    }

    // Get the scripture text
    public string GetText()
    {
        string text = "";

        // Combine words and hidden words to get scripture
        foreach(Word word in scriptureWords)
        {
            text += word.GetWord();
            text += " ";
        }

        return text;
    }

    // Get scripture reference
    public string GetReference()
    {
        return reference.GetReference();
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
            Word word = shownWords[random.Next(0, shownWords.Count)];

            // Double check if word is shown
            if (word.IsShown())
            {
                // Hide and remove word from shown words
                word.HideWord();
                shownWords.Remove(word);

                hiddenWords++;
            }
        }
    }

    // Get if any remaining words shown
    public bool IsShownWords()
    {
        return shownWords.Count != 0;
    }

    // Return scripture length
    public int ScriptureLength()
    {
        return scriptureWords.Length;
    }
}