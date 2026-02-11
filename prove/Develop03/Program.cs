using System;

// Exceeding Requirements: There is a Scripture Library that randomly chooses a scripture
class Program
{
    static void Main(string[] args)
    {
        // Until you have quit the Scripture Memorizer do new scriptures
        bool quit = false;
        while (!quit)
        {
            // Get scripture from the scripture library
            ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
            Scripture scripture = scriptureLibrary.GetScripture();

            // Get scripture reference
            string reference = scripture.GetReference();

            // Show scripture and slowly hide the words. 
            while (true)
            {
                // Clear console
                Console.Clear();

                // Get scripture text with hidden words & display it
                string text = scripture.GetText();
                Console.WriteLine($"{reference} {text}");

                // Display way to quit scripture memorizer
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                // Get response from the player (if any)
                string response = Console.ReadLine();

                // If the user wants to quit or hide more words
                if (response == "quit")
                {
                    // Quit the program
                    quit = true;
                    break;
                }
                else
                {
                    // If there is any remaining shown words hide them
                    if (scripture.IsShownWords()){
                        scripture.HideWords(4);
                    }
                    else
                    {
                        // Display congrats for memorizing the scripture
                        Console.WriteLine("You did it!");
                        
                        // Ask if the user wants to do another scripture
                        Console.WriteLine("Do you want to do another scripture? (yes, no)");
                        string anotherScripture = Console.ReadLine();
                        if (anotherScripture == "yes" || anotherScripture == "y")
                        {
                            // Another scripture
                            break;
                        }
                        else
                        {
                            // Quit / Not another scripture
                            quit = true;
                            break;
                        }
                    }
                }
            }   
        }
    }
}