public static class Stats
{

    public static void DisplayStats(List<SaveData> saveDatas)
    {
        Console.WriteLine($"You have {saveDatas.Count} entries!");
        Console.WriteLine($"You have written in your journal on {CountAmountOfDays(saveDatas)} days!");
        Console.WriteLine();
    }
    

    static int CountAmountOfDays(List<SaveData> saveDatas)
    {
        List<string> times = saveDatas.Select(sd => sd._time).ToList();
        times = times.Distinct().ToList();
        return times.Count;
    }
}