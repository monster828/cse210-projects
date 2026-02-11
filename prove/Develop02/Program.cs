using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        MainMenu mainMenu = new();
        List<SaveData> saveDatas = new();
        while (true)
        {
            int selected = mainMenu.Menu();
            if (selected == 1)
            {
                Prompts prompt = new();
                prompt.DisplayPrompt();
                Console.Write(">");
                string response = Console.ReadLine();
                SaveData saveData = SaveData.CreateSaveData(prompt._prompt, response);
                saveDatas.Add(saveData);
            }else if (selected == 2)
            {
                Stats.DisplayStats(saveDatas);
                foreach(SaveData saveData in saveDatas)
                {
                    saveData.DisplayData();
                    Console.WriteLine();
                }
            }else if (selected == 3)
            {
                saveDatas = SaveSystem.LoadDatas();
            }else if (selected == 4)
            {
                SaveSystem.SaveDatas(saveDatas);
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