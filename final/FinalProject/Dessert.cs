public class Dessert : MenuItem
{
    public Dessert(string name, float cost) : base(name, cost)
    {
        
    }

    public override string GetDetails()
    {
        return $"${GetCost()}  Dessert - {GetName()}";
    }

    public override string GetSaveMenuItemString()
    {
        return $"Dessert:{GetName()}:{GetCost()}";
    }
}