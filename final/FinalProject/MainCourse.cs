public class MainCourse : MenuItem
{
    public MainCourse(string name, float cost) : base(name, cost)
    {
        
    }

    public override string GetDetails()
    {
        return $"${GetCost()}  MainCourse - {GetName()}";
    }
}