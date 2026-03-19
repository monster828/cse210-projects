public class Order
{
    private List<MenuItem> _menuItems;
    private string _customer;

    public Order(string customer, List<MenuItem> menuItems)
    {
        _customer = customer;
        _menuItems = menuItems;
    }

    public Order(string customer)
    {
        _customer = customer;
    }

    public void AddItemToOrder(MenuItem item)
    {
        _menuItems.Add(item);
    }

    public void PrintReceipt()
    {
        Console.WriteLine();
    }
}