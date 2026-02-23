public class Listing : Activity
{
    private int _numberOfItemsEntered;

    public Listing(string[] animationCharacters) : base(animationCharacters)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _numberOfItemsEntered = 0;

        SetPrompts([
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ]);
    }

    public void ListingActivitiy()
    {
        DisplayIntro(_name, _description);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        Countdown(5);

        Console.WriteLine();
        StartActivity();
        while (GetDuration() > 0)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (answer.Length > 0)
            {
                _numberOfItemsEntered++;
            }
        }

        Console.WriteLine($"You listed {_numberOfItemsEntered} items!");

        DisplayEnding(GetEndMessage());
    }
}