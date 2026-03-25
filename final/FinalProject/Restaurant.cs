public class Restaurant
{
    private List<Order> _orders = new();
    private List<MenuItem> _menu = new();

    public Restaurant()
    {
        
    }
    
    public Restaurant(List<Order> orders, List<MenuItem> menuItems)
    {
        _orders = orders;
        _menu = menuItems;
    }

    public List<Order> GetOrders()
    {
        return _orders;
    }

    public List<MenuItem> GetMenuItems()
    {
        return _menu;
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

            int item = -1;
            if (int.TryParse(response, out item))
            {
                item -= 1;
            }

            if (item < _menu.Count && item >= 0)
            {
                MenuItem selectedItem = _menu[item];

                menuOrder.Add(selectedItem.CopyForOrder());
            }
        }

        if (menuOrder.Count > 0)
        {
            Order order = new Order(customer, menuOrder);
            AddOrder(order);
        }
        else
        {
            Console.WriteLine("Please select a menu item for the order.");
        }
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
        if (_orders.Count == 0)
        {
            Console.WriteLine("You currently do not have any orders");
            return;
        }

        Console.WriteLine("Orders:");

        for (int i = 0; i < _orders.Count; i++)
        {
            Order order = _orders[i];
            Console.WriteLine($"{i}. {order.GetDetails()}");
        }
        
        Console.Write("Completed order:");
        string orderString = Console.ReadLine();
        if (int.TryParse(orderString, out int selectedOrder))
        {
            _orders[selectedOrder].PrintReceipt();
            _orders.RemoveAt(selectedOrder);
        }
    }

    public void CreateMenuItem()
    {
        Console.WriteLine();
        Console.Write("Food Name: ");
        string name = Console.ReadLine();

        Console.Write("Category Type (1. Main Course, 2. Drink, 3. Dessert): ");
        string userInput = Console.ReadLine();
        int category = 1;
        if (int.TryParse(userInput, out category))
        {

        }
        else
        {
            Console.WriteLine("Invalid Category Selection");
            return;
        }

        Console.Write("Cost: $");
        userInput = Console.ReadLine();
        float cost = 0;
        if (float.TryParse(userInput, out cost))
        {
            
        }

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
            // Dessert
            menuItem = new Dessert(name, cost);
        }

        if (menuItem != null)
        {
            _menu.Add(menuItem);
        }
    }
}