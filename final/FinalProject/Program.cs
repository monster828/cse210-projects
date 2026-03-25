using System;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new();
        SaveSystem saveSystem = new();
        MainMenu mainMenu = new();

        bool running = true;
        while (running)
        {
            // Main Menu: Save, Load, New Order, Print receipt, Complete order
            switch (mainMenu.GetSelectionInMainMenu())
            {
                // Do thing based off of selected option
                case 1:
                    // Load Restaurant
                    Console.Write("Filename: ");
                    string filename = Console.ReadLine();
                    restaurant = saveSystem.LoadRestaurant(filename);
                    break;
                case 2:
                    // New order
                    restaurant.CreateOrder();
                    break;
                case 3:
                    // Complete order
                    restaurant.CompleteOrder();
                    break;
                case 4:
                    // Update Menu
                    restaurant.CreateMenuItem();
                    break;
                case 5:
                    // Save
                    Console.Write("Filename: ");
                    filename = Console.ReadLine();
                    saveSystem.SaveRestaurant(filename,restaurant);
                    break;
                case 6:
                    // Quit
                    running = false;
                    break;
            }
        }
    }
}