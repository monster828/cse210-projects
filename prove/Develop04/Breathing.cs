public class Breathing : Activity
{
    public Breathing(string[] animationCharacters) : base(animationCharacters)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreathingActivity()
    {
        DisplayIntro(_name, _description);

        StartActivity();
        while (GetDuration() > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");   

            Countdown(3);

            Console.WriteLine();
            Console.Write("Now breathe out...");

            Countdown(6);

            Console.WriteLine();
        }

        DisplayEnding(GetEndMessage());
    }
}