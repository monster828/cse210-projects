public class Restaurant
{
    private List<Order> _orders = new();
    private List<MenuItem> _menu = new();

    public List<Order> GetOrders()
    {
        return _orders;
    }

    public void CreateOrder()
    {
        Console.WriteLine();
        Console.Write("Customer Name: ");
        string customer = Console.ReadLine();

        List<MenuItem> menuOrder = new();
        DisplayMenu();
        Console.WriteLine();
        while (true)
        {
            Console.Write("Item: ");
            string response = Console.ReadLine();
            if (response == "")
            {
                break;
            }

            int item = int.Parse(response) - 1;
            if (item < _menu.Count)
            {
                menuOrder.Add(_menu[item]);
            }
        }

        Order order = new Order(customer, menuOrder);
        AddOrder(order);

        PrintReceipt();
    }

    public void PrintReceipt()
    {
        
    }

    public void DisplayMenu()
    {
        for (int i = 0; i < _menu.Count; i++)
        {
            string name = _menu[i].GetName();
            float cost = _menu[i].GetCost();
            Console.WriteLine($"{i + 1}. {name}  -  ${cost}");
        }
    }

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public void CompleteOrder()
    {
        // _orders.Remove(order);
    }

    public void CreateMenuItem()
    {
        Console.Write("Food Name: ");
        string name = Console.ReadLine();

        Console.Write("Category Type (1. Main Course, 2. Drink, 3. Desert): ");
        int category = int.Parse(Console.ReadLine());

        Console.Write("Cost: ");
        float cost = float.Parse(Console.ReadLine());

        MenuItem menuItem = null;

        if (category == 1)
        {
            // Main Course
            menuItem = new MainCourse(name, cost);
        }else if (category == 2)
        {
            // Drink
            menuItem = new Drink(name, cost);
        }else if (category == 3)
        {
            // Desert
            menuItem = new Desert(name, cost);
        }

        if (menuItem != null)
        {
            _menu.Add(menuItem);
        }
    }
}