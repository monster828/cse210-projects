
public class SaveData
{
    public string _time;
    public string _prompt;
    public string _response;

    public static SaveData CreateSaveData(string prompt, string response)
    {
        SaveData saveData = new();
        saveData._prompt = prompt;
        saveData._response = response;
        System.DateTime dateTime = System.DateTime.Now;
        saveData._time = dateTime.ToShortDateString();
        return saveData;
    }

    public static SaveData LoadSaveData(string prompt, string response, string time)
    {
        SaveData saveData = new();
        saveData._prompt = prompt;
        saveData._response = response;
        saveData._time = time;

        return saveData;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Date: {_time} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }
}