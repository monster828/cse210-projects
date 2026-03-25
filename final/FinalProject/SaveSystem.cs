using System.IO;
public class SaveSystem
{
    public void SaveRestaurant(string filename, Restaurant restaurant)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Menu:");
            List<MenuItem> menuItems = restaurant.GetMenuItems();
            foreach(MenuItem menuItem in menuItems)
            {
                outputFile.WriteLine($"{menuItem.GetSaveMenuItemString()}");
            }

            outputFile.WriteLine("Orders:");
            List<Order> orders = restaurant.GetOrders();
            foreach(Order order in orders)
            {
                outputFile.WriteLine($"{order.GetSaveOrderString()}");
            }
        }
    }

    public Restaurant LoadRestaurant(string filename)
    {
        List<Order> orders = new List<Order>();
        List<MenuItem> menuItems = new List<MenuItem>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            int i = 1; // Skip the first index
            
            // Menu
            while (i < lines.Length && lines[i] != "Orders:")
            {
                string line = lines[i];
                string[] split = line.Split(":");
                
                string name;
                float cost;
                if (split.Length >= 3)
                {
                    name = split[1];
                    cost = float.Parse(split[2]);
                }else
                {
                    i++;
                    continue;
                }
                
                MenuItem menuItem = null;

                if (split[0] == "MainCourse")
                {
                    MainCourse mainCourse = new MainCourse(name, cost);
                    menuItem = mainCourse;
                }else if (split[0] == "Drink")
                {
                    Drink drink = new Drink(name, cost);
                    menuItem = drink;
                }
                else if (split[0] == "Dessert")
                {
                    Dessert dessert = new Dessert(name, cost);
                    menuItem = dessert;
                }
                else
                {
                    MenuItem item = new MenuItem(name, cost);
                    menuItem = item;
                }

                menuItems.Add(menuItem);
                i++;
            }

            i++;
            // Orders
            while (i < lines.Length)
            {
                string line = lines[i];
                string[] split = line.Split(":");
                string customer = split[0];

                List<MenuItem> items = new List<MenuItem>();
                string[] orderMenuItems = split[1].Split(",");
                foreach(string menuItem in orderMenuItems)
                {
                    MenuItem item = menuItems.Find(i => i.GetName() == menuItem);
                    items.Add(item);
                }

                Order order = new Order(customer, items);
                orders.Add(order);
                i++;
            }
        }

        return new Restaurant(orders, menuItems);
    }
}