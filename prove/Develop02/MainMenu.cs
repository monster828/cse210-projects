public class MainMenu
{
    public int Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.WriteLine("What would you like to do?");
        int selected = int.Parse(Console.ReadLine());
        return selected;
    }
}