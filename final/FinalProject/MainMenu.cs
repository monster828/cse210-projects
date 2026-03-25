public class MainMenu
{
    private string[] _mainMenuOptions = ["Load", "New Order","Complete Order","Update menu","Save","Quit"];
    public int GetSelectionInMainMenu()
    {
        Console.WriteLine();
        for (int i = 0; i < _mainMenuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {_mainMenuOptions[i]}");
        }
        Console.Write("Select what you like to do: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            return -1;
        }
    }
}