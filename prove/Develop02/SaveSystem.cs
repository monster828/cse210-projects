using System.IO;
public static class SaveSystem
{
    static string split = "~|~";
    public static void SaveDatas(List<SaveData> saveDatas)
    {
        Console.WriteLine("What do you want to save it as?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(SaveData data in saveDatas)
            {
                outputFile.WriteLine($"{data.prompt}{split}{data.response}{split}{data.time}");   
            }
        }
    }

    public static List<SaveData> LoadDatas()
    {
        Console.WriteLine("What file do you want to load?");
        string filename = Console.ReadLine();
        if (System.IO.File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            List<SaveData> saveDatas = new();

            foreach (string line in lines)
            {
                string[] parts = line.Split(split);
                SaveData saveData = SaveData.LoadSaveData(parts[0],parts[1],parts[2]);
                saveDatas.Add(saveData);
            }

            return saveDatas;
        }
        else
        {
            Console.WriteLine("File not found...");
            return new();
        }
    }
}