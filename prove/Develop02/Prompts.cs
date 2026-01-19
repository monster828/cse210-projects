public class Prompts
{
    public string _prompt;
    string[] prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the hardest thing you did today?",
        "Did you make anything today, if so what?",
    };

    public Prompts()
    {
        Random random = new Random();
        _prompt = prompts[random.Next(prompts.Length)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
    }
}