public class MenuItem
{
    private string _name;
    private float _cost;

    public MenuItem(string name, float cost)
    {
        _name = name;
        _cost = cost;
    }

    public string GetName()
    {
        return _name;
    }

    public float GetCost()
    {
        return _cost;
    }
    
    public virtual string GetDetails()
    {
        return $"${_cost}  {_name}";
    }

    public virtual string GetSaveMenuItemString()
    {
        return $"MenuItem:{_name}:{_cost}";
    }

    public virtual MenuItem CopyForOrder()
    {
        return new MenuItem(_name, _cost);
    }
}