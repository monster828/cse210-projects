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
        _menuItems = new List<MenuItem>();
    }

    public void AddItemToOrder(MenuItem item)
    {
        _menuItems.Add(item);
    }

    public void PrintReceipt()
    {
        float subtotal = 0;
        MenuItem[] menuItems = GetMenuItems();

        Console.WriteLine("\n===============================");
        Console.WriteLine("       RESTAURANT RECEIPT      ");
        Console.WriteLine("===============================");
        Console.WriteLine($"Customer: {GetCustomer()}");
        Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
        Console.WriteLine("-------------------------------");

        Console.WriteLine($"{"Item",-22} {"Price",8}");
        Console.WriteLine("-------------------------------");

        for (int i = 0; i < menuItems.Length; i++)
        {
            MenuItem menuItem = menuItems[i];
            string name = menuItem.GetName();
            float cost = menuItem.GetCost();

            Console.WriteLine($"{name, -22} ${cost, 7:N2}");

            subtotal += cost;
        }

        float tax = subtotal * 0.08f; // 8% tax
        float total = subtotal + tax;

        Console.WriteLine("-------------------------------");
        Console.WriteLine($"{"Subtotal:", -22} ${subtotal,7:N2}");
        Console.WriteLine($"{"Tax:", -22} ${tax, 7:N2}");
        Console.WriteLine("===============================");
        Console.WriteLine($"{"Total:", -22} ${total, 7:N2}");
        Console.WriteLine("===============================");
        Console.WriteLine("   Thank you for dining!   \n");
    }

    public string GetSaveOrderString()
    {
        string saveData = _customer;

        saveData += ":";

        foreach (MenuItem menuItem in _menuItems)
        {
            saveData += $"{menuItem.GetName()},";
        }

        return saveData;
    }

    public string GetDetails()
    {
        return $"{_customer}";
    }

    public string GetCustomer()
    {
        return _customer;
    }

    public MenuItem[] GetMenuItems()
    {
        return _menuItems.ToArray();
    }
}