public class Drink : MenuItem
{
    public enum Size {Large, Medium, Small};
    private Size _size;

    public Drink(string name, float cost) : base(name, cost)
    {

    }

    public Drink(string name, float cost, Size size) : base(name, cost)
    {
        _size = size;
    }

    public override string GetDetails()
    {
        return $"${GetCost()}  Drink - {GetName()} ({_size})";
    }

    public override string GetSaveMenuItemString()
    {
        return $"Drink:{GetName()}:{GetCost()}:{_size}";
    }

    public override MenuItem CopyForOrder()
    {
        Console.WriteLine("1. Large +$1.00  2. Medium +$0.50  3. Small +$0.00");
        Console.Write("Which size do you want? ");

        Size selectedSize = Size.Large;

        string userInput = Console.ReadLine();
        int size = 1;
        if (int.TryParse(userInput, out size))
        {
            
        }

        float finalCost = GetCost();

        switch (size)
        {
            case 1:
                selectedSize = Size.Large;
                finalCost += 1.00f;
                break;
            case 2:
                selectedSize = Size.Medium;
                finalCost += 0.50f;
                break;
            default:
                selectedSize = Size.Small;
                break;
        }

        return new Drink(GetName(), finalCost, selectedSize);
    }
}