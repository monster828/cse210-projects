public class Activity
{
    protected private string _name;
    protected private string _description;
    private string _endMessage;
    private string[] _prompts;
    private float _duration;
    private DateTime _startTime;
    private DateTime _finishTime;
    private string[] _animationCharacters;

    private List<string> _usedPrompts = new List<string>();

    public Activity(string[] animationCharacters)
    {
        _animationCharacters = animationCharacters;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetEndMessage()
    {
        _endMessage = $"You have completed another {_duration} seconds of the {_name}!";
        return _endMessage;
    }
    
    public void SetPrompts(string[] prompts)
    {
        _prompts = prompts;
        _usedPrompts = new List<string>();
    }

    public string[] GetPrompts()
    {
        return _prompts;
    }

    public string[] GetAnimationCharacters()
    {
        return _animationCharacters;
    }

    public string GetRandomPrompt(string[] prompts)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, prompts.Length);
        while (_usedPrompts.Contains(prompts[randomNumber]))
        {
            randomNumber = random.Next(0, prompts.Length);
        }

        if (prompts.Length == _usedPrompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt = prompts[randomNumber];
        _usedPrompts.Add(prompt);
        return prompt;
    }

    public void SetDuration(float duration)
    {
        _duration = duration;
    }

    public float GetDuration()
    {
        return (_finishTime - DateTime.Now).Seconds;
    }

    public void StartActivity()
    {
        _startTime = DateTime.Now;
        _finishTime = _startTime.AddSeconds(_duration);
    }

    public void DisplayIntro(string name, string description)
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {name}:");

        Console.WriteLine();

        Console.WriteLine(description);

        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadAnimation(5, GetAnimationCharacters());
    }

    public void DisplayEnding(string endMessage)
    {
        Console.WriteLine();

        Console.WriteLine("Well done!!!");
        LoadAnimation(5, GetAnimationCharacters());
        
        Console.WriteLine();

        Console.WriteLine(endMessage);
        
        LoadAnimation(5, GetAnimationCharacters());
    }

    public void LoadAnimation(float duration, string[] animationCharacters)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int animation = 0;
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.Write($"\b \b{animationCharacters[animation]}");

            animation++;
            if (animation == animationCharacters.Length)
            {
                animation = 0;
            }

            Thread.Sleep(750);

            currentTime = DateTime.Now;
        }

        Console.Write($"\b \b");
    }

    public void Countdown(int duration)
    {
        for (int i = 0; i <= duration; duration--)
        {
            Console.Write(duration);

            Thread.Sleep(1000);

            Console.Write($"\b \b");
        }
    }
}