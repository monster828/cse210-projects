public class Drink : MenuItem
{
    public Drink(string name, float cost) : base(name, cost)
    {
        
    }

    public override string GetDetails()
    {
        return $"${GetCost()}  Drink - {GetName()}";
    }
}