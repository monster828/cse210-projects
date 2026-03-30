public class Journal
{
    private List<SaveData> _saveDatas = new();
    

    public void Write()
    {
        Prompts prompt = new();
        prompt.DisplayPrompt();
        Console.Write(">");
        string response = Console.ReadLine();
        SaveData saveData = SaveData.CreateSaveData(prompt.GetPrompt(), response);
        _saveDatas.Add(saveData);
    }

    public void Display()
    {
        DisplayStats(_saveDatas);
        foreach(SaveData saveData in _saveDatas)
        {
            saveData.DisplayData();
            Console.WriteLine();
        }
    }

    public void LoadDatas()
    {
        _saveDatas = SaveSystem.LoadDatas();
    }

    public void SaveDatas()
    {
        SaveSystem.SaveDatas(_saveDatas);
    }

    public void DisplayStats(List<SaveData> saveDatas)
    {
        Console.WriteLine($"You have {saveDatas.Count} entries!");
        Console.WriteLine($"You have written in your journal on {CountAmountOfDays(saveDatas)} days!");
        Console.WriteLine();
    }
    

    private int CountAmountOfDays(List<SaveData> saveDatas)
    {
        List<string> times = saveDatas.Select(sd => sd.GetTime()).ToList();
        times = times.Distinct().ToList();
        return times.Count;
    }
}