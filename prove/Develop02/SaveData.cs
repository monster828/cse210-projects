
public class SaveData
{
    public string time;
    public string prompt;
    public string response;

    public static SaveData CreateSaveData(string prompt, string response)
    {
        SaveData saveData = new();
        saveData.prompt = prompt;
        saveData.response = response;
        System.DateTime dateTime = System.DateTime.Now;
        saveData.time = dateTime.ToShortDateString();
        return saveData;
    }

    public static SaveData LoadSaveData(string prompt, string response, string time)
    {
        SaveData saveData = new();
        saveData.prompt = prompt;
        saveData.response = response;
        saveData.time = time;

        return saveData;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Date: {time} - Prompt: {prompt}");
        Console.WriteLine($"{response}");
    }
}