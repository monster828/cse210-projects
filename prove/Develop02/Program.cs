using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        MainMenu mainMenu = new();
        Journal journal = new();
        while (true)
        {
            int selected = mainMenu.Menu();
            if (selected == 1)
            {
                journal.Write();
            }else if (selected == 2)
            {
                journal.Display();
            }else if (selected == 3)
            {
                journal.LoadDatas();
            }else if (selected == 4)
            {
                journal.SaveDatas();
            }else if (selected == 5)
            {
                Console.WriteLine("Quitting...");
                break;
            }
            else
            {
                Console.WriteLine("Please choose a valid number from 1-6");
            }
        }
  
    }
}