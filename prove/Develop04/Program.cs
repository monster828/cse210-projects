using System;

// After showing a prompt, that prompt will not show again until all of the other prompts are shown.
class Program
{
    static void Main(string[] args)
    {
        string[] animationCharacters = [
            "|", "/", "-", "\\",
        ];

        int completedActivities = 0;

        while (true)
        {
            Console.Clear();
            Menu();
            int selected = int.Parse(Console.ReadLine());
            
            if (selected == 1)
            {
                Breathing breathing = new Breathing(animationCharacters);
                breathing.BreathingActivity();
                
                completedActivities++;
            }else if (selected == 2)
            {   
                Reflection reflection = new Reflection(animationCharacters);
                reflection.RefelctionActivity();
                
                completedActivities++;
            }else if (selected == 3)
            {
                Listing listening = new Listing(animationCharacters);
                listening.ListingActivitiy();

                completedActivities++;
            }else if (selected == 4)
            {
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You have completed {completedActivities} of activities!");
    }

    static void Menu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}