public class Desert : MenuItem
{
    public Desert(string name, float cost) : base(name, cost)
    {
        
    }

    public override string GetDetails()
    {
        return $"${GetCost()}  Desert - {GetName()}";
    }
}